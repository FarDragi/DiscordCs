using FarDragi.DiscordCs.Core.Websocket;

namespace FarDragi.DiscordCs.Core.Client
{
    public class ClientConfig
    {
        public string Token { get; }

        public ClientConfig(string token)
        {
            Token = token;
        }
    }
}
