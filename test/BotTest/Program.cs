using FarDragi.DiscordCs;
using FarDragi.DiscordCs.Entities.GuildModels;
using System;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace BotTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string token = ConfigurationManager.AppSettings["token"];
            if (token == null)
            {
                Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                KeyValueConfigurationCollection settings = configFile.AppSettings.Settings;
                Console.Write("Token: ");
                token = Console.ReadLine();
                settings.Add("token", token);
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }

            Client client = new(new ClientConfig
            {
                Token = token
            });

            client.GuildCreate += Client_GuildCreate;

            client.Login();

            await Task.Delay(-1);
        }

        private static Task Client_GuildCreate(Client client, ClientEventArgs<Guild> args)
        {
            Console.WriteLine($"[{args.Data.Id}] [{args.Data.Name}]");

            if (ReferenceEquals(client.Guilds[args.Data.Id], args.Data))
            {
                if (ReferenceEquals(args.Data, client.Guilds.First(x => x.Id == args.Data.Id)))
                {
                    Console.WriteLine("true");
                }
            }

            return Task.CompletedTask;
        }
    }
}
