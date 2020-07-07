namespace FarDragi.DragiCordApi.Core.Gateway.Client
{
    internal sealed class GatewayConfig
    {
        internal const string GatewayUrl = "wss://gateway.discord.gg/?v={0}&encoding={1}";
        internal const uint ApiVersion = 7;
        internal const string Encoding = "json";
    }
}
