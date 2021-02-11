using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace FarDragi.DiscordCs.Rest
{
    public class RestClient
    {
        private readonly HttpClient httpClient;
        private readonly RestConfig config;
        private readonly Queue<object> payloads;

        public RestClient(RestConfig restConfig)
        {
            config = restConfig;
            config.Version = 8;
            httpClient = new HttpClient
            {
                BaseAddress = new Uri(config.Url)
            };
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bot", config.Token);
            payloads = new Queue<object>();
        }
    }
}
