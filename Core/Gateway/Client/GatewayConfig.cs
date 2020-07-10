namespace FarDragi.DragiCordApi.Core.Gateway.Client
{
    internal sealed class GatewayConfig
    {
        internal const string GatewayUrl = "wss://gateway.discord.gg/?v={0}&encoding={1}&compress=zlib-stream";
        internal const uint ApiVersion = 6;
        internal const string Encoding = "json";
    }
}
