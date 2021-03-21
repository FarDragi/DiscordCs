using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Rest.Standard.Models
{
    public class Payload
    {
        public HttpRequestMessage Request { get; set; }
        public TaskCompletionSource<HttpResponseMessage> Response { get; set; }
    }
}
