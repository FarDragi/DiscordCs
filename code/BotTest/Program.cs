using FarDragi.DiscordCs;
using FarDragi.DiscordCs.Args;
using FarDragi.DiscordCs.Entity.Models.ChannelModels;
using FarDragi.DiscordCs.Entity.Models.GuildModels;
using FarDragi.DiscordCs.Entity.Models.IdentifyModels;
using FarDragi.DiscordCs.Entity.Models.MessageModels;
using FarDragi.DiscordCs.Entity.Models.ReadyModels;
using FarDragi.DiscordCs.Logging;
using System;
using System.Configuration;
using System.Threading.Tasks;

namespace BotTest
{
    static class Program
    {

        static async Task Main()
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
                Identify =
                {
                    Token = token,
                    Intents = IdentifyIntent.Default
                },
                Logger =
                {
                    Level = LoggingLevel.Info
                },
            });

            client.Ready += Client_Ready;
            client.GuildCreate += Client_GuildCreate;
            client.MessageCreate += Client_MessageCreate;

            await client.Login();
        }

        private static async Task Client_MessageCreate(Client client, ClientArgs<Message> args)
        {
            client.Logger.Log(LoggingLevel.Dcs, args.Data.Content);

            if (!args.Data.Author.IsBot || args.Data.Author.Id == 730094287345156136)
            {
                await (client.Channels.Find(args.Data.ChannelId) as TextGuildChannel).Messages.Add(new Message
                {
                    Content = (Convert.ToInt32(args.Data.Content) + 1).ToString()
                });
            }
        }

        private static Task Client_GuildCreate(Client client, ClientArgs<Guild> args)
        {
            return Task.CompletedTask;
        }

        private static Task Client_Ready(Client client, ClientArgs<Ready> args)
        {
            return Task.CompletedTask;
        }
    }
}
