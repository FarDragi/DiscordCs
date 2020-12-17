using System;
using System.Threading.Tasks;

namespace DiscordCsBotTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Write("Digite o token: ");
            var bot = new Bot(Console.ReadLine());
            bot.Start();

            await Task.Delay(-1);
        }
    }
}
