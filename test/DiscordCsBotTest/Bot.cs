using FarDragi.DiscordCs.Core.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordCsBotTest
{
    public class Bot
    {
        private readonly DiscordClient client;

        public Bot(string token)
        {
            client = new DiscordClient(new ClientConfig(token)
            {
                 
            });
            client.Raw += Client_Raw;
        }

        private Task Client_Raw(string data)
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            client.Connect();
        }
    }
}
