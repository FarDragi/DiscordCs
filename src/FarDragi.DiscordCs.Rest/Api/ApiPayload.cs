using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Rest.Api
{
    public class ApiPayload
    {
        public HttpRequestMessage Request { get; set; }
        public TaskCompletionSource<HttpResponseMessage> Response { get; set; }
    }
}
