using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace FarDragi.DiscordCs.Rest
{
    public class RestClient
    {
        private readonly HttpClient httpClient;
        private readonly RestConfig config;

        public RestClient(RestConfig restConfig)
        {
            config = restConfig;
            httpClient = new HttpClient();
        }
    }
}
