using FarDragi.DragiCordApi.Core.Base.Client;
using FarDragi.DragiCordApi.Core.Base.Models.Base;
using FarDragi.DragiCordApi.Core.Base.Models.EventsArgs;
using System.Threading.Tasks;

namespace FarDragi.DragiCordApi.Teste
{
    public class DragiCordApiTest
    {
        private readonly DiscordClient _client;

        public DragiCordApiTest(string token)
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
