using FarDragi.DiscordCs.Rest.Standard.Models;
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
        private readonly Queue<Payload> _payloads;

        public RestClient(HttpClient httpClient, string urlFormat)
        {
            _httpClient = httpClient;
            _urlFormat = urlFormat;
            _payloads = new Queue<Payload>();
        }
    }
}
