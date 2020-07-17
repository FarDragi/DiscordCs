using FarDragi.DiscordCs.Core.Rest.Models.Identify;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace FarDragi.DiscordCs.Core.Rest.Client
{
    internal class RestClient : IDisposable
    {
        private HttpClient _client;
        private IdentifyRest _identify;

        internal RestClient(IdentifyRest identify)
        {
            _identify = identify;
            _client = new HttpClient
            {
                BaseAddress = new Uri(string.Format(RestConfig.RestUrl, RestConfig.ApiVersion))
            };
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bot", _identify.Token);
        }

        public void Dispose()
        {
            _client.Dispose();
        }
    }
}
