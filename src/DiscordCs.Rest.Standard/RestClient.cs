using FarDragi.DiscordCs.Rest.Standard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Rest.Standard
{
    public class RestClient : IRestClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _urlFormat;
        private readonly JsonSerializerOptions _serializerOptions;
        private readonly Queue<Payload> _payloads;

        private static bool _rateLimitiGlobal = false;
        private static int _rateLimitiGlobalCooldown = 0;

        private bool _sending;
        private int _remaining = 1;

        public RestClient(HttpClient httpClient, string urlFormat, JsonSerializerOptions serializerOptions)
        {
            _httpClient = httpClient;
            _urlFormat = urlFormat;
            _serializerOptions = serializerOptions;
            _payloads = new Queue<Payload>();
        }

        private async Task Enqueue(HttpMethod method, string json, string[] urlParams, TaskCompletionSource<HttpResponseMessage> response)
        {
            HttpRequestMessage request = new HttpRequestMessage(method, string.Format(_urlFormat, urlParams))
            {
                Content = new StringContent(json)
                {
                    Headers =
                    {
                        ContentType = new MediaTypeHeaderValue("application/json")
                    }
                }
            };

            _payloads.Enqueue(new Payload
            {
                Request = request,
                Response = response
            });

            if (!_sending)
            {
                _sending = true;
                await SendLoop().ConfigureAwait(false);
            }
        }

        private async Task SendLoop()
        {
            IEnumerable<string> values;

            while (_payloads.TryDequeue(out Payload payload))
            {
                if (_rateLimitiGlobal)
                {
                    await Task.Delay(_rateLimitiGlobalCooldown);
                }

                HttpResponseMessage httpResponseMessage = await _httpClient.SendAsync(payload.Request);

                payload.Response.SetResult(httpResponseMessage);

                if (httpResponseMessage.Headers.TryGetValues("X-RateLimit-Remaining", out values))
                {
                    _remaining = int.Parse(values.First());
                }


                if (_remaining == 0)
                {
                    if (httpResponseMessage.Headers.TryGetValues("X-RateLimit-Global", out values))
                    {
                        if (!bool.TryParse(values.First(), out bool result))
                        {
                            // TODO: Error
                        }
                        else
                        {
                            _rateLimitiGlobal = result;
                        }
                    }

                    if (httpResponseMessage.Headers.TryGetValues("X-RateLimit-Reset-After", out values))
                    {
                        int milis = (int)Convert.ToDouble(values.First());
                        Console.WriteLine(milis);
                        await Task.Delay(milis);
                    }
                    else
                    {
                        // TODO: Error
                    }
                }
            }

            _sending = false;
        }

        public async Task<TOutput> Send<TInput, TOutput>(HttpMethod method, TInput input, params string[] urlParams) where TInput : class where TOutput : class
        {
            TaskCompletionSource<HttpResponseMessage> responseTask = new TaskCompletionSource<HttpResponseMessage>();

            await Enqueue(method, JsonSerializer.Serialize(input, _serializerOptions), urlParams, responseTask);

            HttpResponseMessage response = await responseTask.Task;

            if (response.IsSuccessStatusCode)
            {
                return JsonSerializer.Deserialize<TOutput>(await response.Content.ReadAsStringAsync(), _serializerOptions);
            }

            return null;
        }
    }
}
