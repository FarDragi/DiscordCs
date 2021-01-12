using FarDragi.DiscordCs.Client;
using System;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Test.Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            DiscordClient client = new();
            client.Login("");

            await Task.Delay(-1);
        }
    }
}
