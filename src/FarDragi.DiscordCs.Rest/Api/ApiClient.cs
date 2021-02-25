using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Rest.Api
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly Queue<ApiPayload> _payloads;
        private readonly string _url;
        private bool _sending;

        public ApiClient(HttpClient httpClient, string url)
        {
            _httpClient = httpClient;
            _url = url;
            _payloads = new Queue<ApiPayload>();
            _sending = false;
        }

        private void Enqueue(HttpMethod method, string json, object[] urlParams, TaskCompletionSource<HttpResponseMessage> response)
        {
            HttpRequestMessage request = new HttpRequestMessage(method, string.Format(_url, urlParams))
            {
                Content = new StringContent(json)
                {
                    Headers =
                    {
                        ContentType = new MediaTypeHeaderValue("application/json")
                    }
                }
            };

            _payloads.Enqueue(new ApiPayload
            {
                Request = request,
                Response = response
            });

            if (!_sending)
            {
                _sending = true;
                SendLoop();
            }
        }

        private async void SendLoop()
        {
            while (_payloads.TryDequeue(out ApiPayload payload))
            {
                payload.Response.SetResult(await _httpClient.SendAsync(payload.Request));
            }

            _sending = false;
        }

        public async Task<TOutput> Send<TInput, TOutput>(HttpMethod method, TInput input, params object[] urlParams) where TInput : class where TOutput : class
        {
            TaskCompletionSource<HttpResponseMessage> responseTask = new TaskCompletionSource<HttpResponseMessage>();

            Enqueue(method, JsonConvert.SerializeObject(input), urlParams, responseTask);

            HttpResponseMessage response = await responseTask.Task;

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<TOutput>(await response.Content.ReadAsStringAsync());
            }

            return null;
        }
    }
}
