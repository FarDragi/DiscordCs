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
                Token = "NzMwMDk0Mjg3MzQ1MTU2MTM2.XwY8MA.wMYfAaAWKJ7kVAEedWTyK4oWDM4"
            };
            await client.Connect();
            await Task.Delay(-1);
        }
    }
}
