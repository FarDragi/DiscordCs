﻿using FarDragi.DiscordCs.Rest.Standard.Models;
using System;
using System.Collections.Generic;
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
        private bool _sending;

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
                await SendLoop().ConfigureAwait(false);
            }
        }

        private async Task SendLoop()
        {
            while (_payloads.TryDequeue(out Payload payload))
            {
                payload.Response.SetResult(await _httpClient.SendAsync(payload.Request));
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