﻿using FarDragi.DiscordCs;
using FarDragi.DiscordCs.Args;
using FarDragi.DiscordCs.Entity.Models.ChannelModels;
using FarDragi.DiscordCs.Entity.Models.EmbedModels;
using FarDragi.DiscordCs.Entity.Models.GuildModels;
using FarDragi.DiscordCs.Entity.Models.IdentifyModels;
using FarDragi.DiscordCs.Entity.Models.MessageModels;
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

            await client.Login();
        }

        private static async Task Client_MessageUpdate(Client client, ClientArgs<MessageUpdate> args)
        {
            await args.Data.Message.Channel.Messages.Add("oi fdp");
        }

        private static async Task Client_MessageCreate(Client client, ClientArgs<Message> args)
        {
            client.Logger.Log(LoggingLevel.Dcs, args.Data.Content);

            if ((!args.Data.Author.IsBot || args.Data.Author.Id == client.User.Id) && args.Data.ChannelId == 814019791958441994)
            {
                Embed embed = new Embed
                {
                    Title = new string('a', 256),
                    Description = new string('b', 2048),
                    Footer = new EmbedFooter
                    {
                        Text = new string('c', 2048)
                    },
                    Author = new EmbedAuthor
                    {
                        Name = new string('d', 256)
                    }
                };

                args.Data.Content = "teste";
                Message msg = args.Data;
                msg.Content = "segundo teste";

                await args.Data.Channel.Messages.Add(embed);

                await args.Data.Channel.Messages.Add(new Embed
                {
                    Title = "Teste",
                    Description = (Convert.ToUInt64(args.Data.Content) + 1).ToString()
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
