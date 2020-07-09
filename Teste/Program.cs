using FarDragi.DragiCordApi.Core.Client;
using System;
using System.Threading.Tasks;

namespace FarDragi.DragiCordApi.Teste
{
    class Program
    {
        static async Task Main(string[] args)
        {
            DiscordClient client = new DiscordClient
            {
                Token = ""
            };
            await client.Connect();
            await Task.Delay(-1);
        }
    }
}
