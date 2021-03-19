using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace FarDragi.DiscordCs.Rest.Standard
{
    public class RestContext : IRestContext
    {
        private RestConfig _config;
        private HttpClient _httpClient;

        public void Init()
        {
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri(_config.Url),
                DefaultRequestHeaders =
                {
                    Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(_config.Type, _config.Token)
                }
            };
        }

        public IRestClient GetClient(string urlFormat)
        {
            return new RestClient(_httpClient, urlFormat);
        }

        public void Config(IRestConfig config)
        {
            if (config is RestConfig restConfig)
            {
                _config = restConfig;
            }
        }
    }
}
