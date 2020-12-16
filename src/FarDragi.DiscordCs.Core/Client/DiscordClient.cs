using FarDragi.DiscordCs.Core.Client.Interfaces;

namespace FarDragi.DiscordCs.Core.Client
{
    public class DiscordClient : IClientData, IClientEvents
    {
        private ClientBase[] clients;

        public event IClientEvents.EventRaw Raw;

        public ClientConfig Config { get; init; }

        public DiscordClient(ClientConfig config)
        {
            Config = config;
        }

        public void OnRaw(string data)
        {
            Raw.Invoke(data);
        }
    }
}
