using FarDragi.DiscordCs.Core.Websocket;

namespace FarDragi.DiscordCs.Core.Client
{
    public class ConfigClient
    {
        private string token;

        public ConfigWebsocket ConfigWebsocket { get; }

        public ConfigClient(string token)
        {
            ConfigWebsocket = new ConfigWebsocket();
            Token = token;
        }

        public string Token 
        { 
            get => token; 
            init
            {
                token = value;
                ConfigWebsocket.Token = value;
            }
        }
    }
}
