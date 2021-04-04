using FarDragi.DiscordCs.Logging;
using FarDragi.DiscordCs.Rest.Standard.Exceptions;
using FarDragi.DiscordCs.Rest.Standard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Rest.Standard
{
    public class RestClient : IRestClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _urlFormat;
        private readonly JsonSerializerOptions _serializerOptions;
        private readonly ILogger _logger;
        private readonly Queue<Payload> _payloads;

        private static bool RateLimitiGlobal { get; set; }
        private static DateTimeOffset RateLimitiGlobalCooldown { get; set; }

        private bool _sending;
        private int _remaining = 1;

        public RestClient(HttpClient httpClient, string urlFormat, JsonSerializerOptions serializerOptions, ILogger logger)
        {
            _httpClient = httpClient;
            _urlFormat = urlFormat;
            _serializerOptions = serializerOptions;
            _logger = logger;
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
            while (_payloads.TryDequeue(out Payload payload))
            {
                HttpResponseMessage httpResponseMessage;
                do
                {
                    if (RateLimitiGlobal)
                    {
                        TimeSpan cooldown = RateLimitiGlobalCooldown - DateTimeOffset.UtcNow;

                        if (cooldown.TotalMilliseconds > 0)
                        {
                            await Task.Delay(RateLimitiGlobalCooldown - DateTimeOffset.UtcNow);
                        }
                    }

                    httpResponseMessage = await _httpClient.SendAsync(payload.Request);

                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        payload.Response.SetResult(httpResponseMessage);
                    }
                    else
                    {
                        _logger.Log(LoggingLevel.Warning, $"[Rest] {(int)httpResponseMessage.StatusCode}");
                    }

                    if (httpResponseMessage.Headers.TryGetValues("X-RateLimit-Remaining", out IEnumerable<string> values))
                    {
                        if (int.TryParse(values.First(), out int result))
                        {
                            _remaining = result;
                        }
                        else
                        {
                            _remaining = 0;
                        }
                    }
                    else
                    {
                        _logger.Log(LoggingLevel.Error, "[Rest] RateLimit remainig fail get");
                    }

                    if (httpResponseMessage.Headers.TryGetValues("X-RateLimit-Global", out values))
                    {
                        if (bool.TryParse(values.First(), out bool result))
                        {
                            RateLimitiGlobal = result;

                            if (RateLimitiGlobal && httpResponseMessage.Headers.TryGetValues("X-RateLimit-Reset", out values))
                            {
                                long milis = (long)Convert.ToDouble(values.First());
                                RateLimitiGlobalCooldown = DateTimeOffset.FromUnixTimeMilliseconds(milis);
                                continue;
                            }
                        }
                        else
                        {
                            _logger.Log(LoggingLevel.Error, "[Rest] RateLimit global fail parse");
                        }
                    }

                    if (_remaining == 0)
                    {
                        if (httpResponseMessage.Headers.TryGetValues("X-RateLimit-Reset", out values))
                        {
                            long milis = (long)Convert.ToDouble(values.First());
                            DateTimeOffset date = DateTimeOffset.FromUnixTimeMilliseconds(milis);
                            TimeSpan cooldown = date - DateTimeOffset.UtcNow;

                            if (cooldown.TotalMilliseconds > 0)
                            {
                                await Task.Delay(cooldown);
                            }
                        }
                        else
                        {
                            _logger.Log(LoggingLevel.Error, "RateLimit reset fail get");
                        }
                    }
                } while (httpResponseMessage?.StatusCode == HttpStatusCode.TooManyRequests);
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
            else
            {
                string reason = await response.Content.ReadAsStringAsync();
                _logger.Log(LoggingLevel.Warning, $"[Rest] ({(int)response.StatusCode}) Reason: {reason}");
                throw new DiscordApiException((int)response.StatusCode, reason);
            }
        }
    }
}
