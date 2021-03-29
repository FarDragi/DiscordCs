using System;
using System.Runtime.Serialization;

namespace FarDragi.DiscordCs.Rest.Standard.Exceptions
{
    [Serializable]
    public class DiscordApiException : Exception
    {
        public DiscordApiException(int code, string message) : base(message)
        {
            Code = code;
        }

        protected DiscordApiException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public int Code { get; }
    }
}
