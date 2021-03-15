using FarDragi.DiscordCs;
using FarDragi.DiscordCs.Args;
using FarDragi.DiscordCs.Entity.Models.GuildModels;
using FarDragi.DiscordCs.Entity.Models.IdentifyModels;
using FarDragi.DiscordCs.Entity.Models.ReadyModels;
using FarDragi.DiscordCs.Logging;
using System;
using System.Configuration;
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

            Client client = new Client(new ClientConfig
            {
                Identify =
                {
                    Token = token,
                    Intents = IdentifyIntent.Default
                },
                Logger =
                {
                    Level = LoggingLevel.Info
                },
                Rest =
                {
                    Config =
                    {
                        Type = "Bearer"
                    }
                }
            });

            client.Ready += Client_Ready;
            client.GuildCreate += Client_GuildCreate;

            await client.Login();
        }

        private async static Task Client_GuildCreate(Client client, ClientArgs<Guild> args)
        {
        }

        private async static Task Client_Ready(Client client, ClientArgs<Ready> args)
        {
        }
    }
}
