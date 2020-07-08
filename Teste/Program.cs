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
                Token = "NzMwMDk0Mjg3MzQ1MTU2MTM2.XwXcnw.UXpdqXOilSC_DefKox4M9YL2G60"
            };
            await client.Connect();
            await Task.Delay(-1);
        }
    }
}
