using FarDragi.DiscordCs;
using FarDragi.DiscordCs.Args;
using FarDragi.DiscordCs.Entity.Models.ChannelModels;
using FarDragi.DiscordCs.Entity.Models.EmbedModels;
using FarDragi.DiscordCs.Entity.Models.GuildModels;
using FarDragi.DiscordCs.Entity.Models.IdentifyModels;
using FarDragi.DiscordCs.Entity.Models.MessageModels;
using FarDragi.DiscordCs.Entity.Models.PresenceModels;
using FarDragi.DiscordCs.Entity.Models.ReadyModels;
using FarDragi.DiscordCs.Logging;
using System;
using System.Configuration;
using System.Linq;
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
            client.MessageUpdate += Client_MessageUpdate;
            client.MessageDelete += Client_MessageDelete;

            await client.Login();
        }

        private static async Task Client_MessageDelete(Client client, ClientArgs<Message> args)
        {
            client.Logger.Log(LoggingLevel.Info, args.Data.Id.ToString());
        }

        private static async Task Client_MessageUpdate(Client client, ClientArgs<MessageUpdate> args)
        {
            //await args.Data.Message.Channel.Messages.Add("oi fdp");
        }

        private static async Task Client_MessageCreate(Client client, ClientArgs<Message> args)
        {
            client.Logger.Log(LoggingLevel.Dcs, args.Data.Content);

            Message message = args.Data;

            if (message.ChannelId == 814019791958441994)
            {
                await args.Data.Channel.Messages.Delete(message);
                Message updateMessage = new()
                {
                    Id = 836360623100133376,
                    Content = message.Content
                };

                await args.Data.Channel.Messages.Update(updateMessage);
            }
        }

        private static Task Client_GuildCreate(Client client, ClientArgs<Guild> args)
        {
            client.Logger.Log(LoggingLevel.Dcs, args.Data.Name);

            return Task.CompletedTask;
        }

        private static Task Client_Ready(Client client, ClientArgs<Ready> args)
        {
            return Task.CompletedTask;
        }
    }
}
