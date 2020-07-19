using FarDragi.DiscordCs.Core.Client;
using FarDragi.DiscordCs.Core.Models.Base.Bot;
using FarDragi.DiscordCs.Core.Models.Base.Role;
using FarDragi.DiscordCs.Core.Models.EventsArgs;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Test
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
            _client.GuildCreate += Client_GuildCreate;
        }

        private Task Client_GuildCreate(EventGuildCreateArgs e)
        {
            System.Console.WriteLine(e.Data.Name);
            return Task.CompletedTask;
        }

        private Task Client_Ready(EventReadyArgs e)
        {
            System.Console.WriteLine("Bot Ready");
            return Task.CompletedTask;
        }

        public async Task Start()
        {
            await _client.Connect();
            await Task.Delay(-1);
        }
    }
}
