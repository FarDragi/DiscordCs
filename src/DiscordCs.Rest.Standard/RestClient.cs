using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace FarDragi.DiscordCs.Rest.Standard
{
    public class RestClient : IRestClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _urlFormat;

        public RestClient(HttpClient httpClient, string urlFormat)
        {
            _httpClient = httpClient;
            _urlFormat = urlFormat;
        }
    }
}
