using FarDragi.DiscordCs.Rest.Api;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace FarDragi.DiscordCs.Rest
{
    public class RestClient
    {
        private readonly HttpClient _httpClient;
        private readonly RestConfig _config;

        public RestClient(RestConfig restConfig)
        {
            _config = restConfig;
            _config.Version = 8;
            _httpClient = new HttpClient
            {
                DefaultRequestHeaders =
                {
                    Authorization = new AuthenticationHeaderValue("Bot", _config.Token)
                }
            };
        }

        public ApiClient GetApiClient(string url)
        {
            return new ApiClient(_httpClient, _config.Url + url);
        }
    }
}
