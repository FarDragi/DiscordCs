using FarDragi.DiscordCs.Core.Base.Client;
using FarDragi.DiscordCs.Core.Base.Models.Base;
using FarDragi.DiscordCs.Core.Base.Models.EventsArgs;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Teste
{
    public class DiscordCsTest
    {
        private readonly DiscordClient _client;

        public DiscordCsTest(string token)
        {
            _client = new DiscordClient(new DiscordClientConfig
            {
                Token = token,
                Shards = new DiscordShards
                {
                    ShardId = 0,
                    ShardCount = 1
                }
            });

            _client.Ready += Client_Ready;
        }

        private Task Client_Ready(ReadyEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        public async Task Start()
        {
            await _client.Connect();
            await Task.Delay(-1);
        }
    }
}
