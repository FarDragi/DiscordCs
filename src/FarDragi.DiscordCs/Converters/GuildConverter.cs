using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entities.ChannelModels;
using FarDragi.DiscordCs.Entities.GuildModels;
using FarDragi.DiscordCs.Entities.PermissionModels;
using FarDragi.DiscordCs.Json.Entities.GuildModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Converters
{
    public static class GuildConverter
    {
        public static Guild ToGuild(this JsonGuild json, ICacheConfig cacheConfig, Client client)
        {
            Guild guild = json;

            guild.Channels = new ChannelCollection(cacheConfig.GetCache<Channel>());

            Parallel.For(0, json.Channels.Length, i =>
            {
                Channel channel = null;

                switch ((ChannelTypes)json.Channels[i].Type)
                {
                    case ChannelTypes.GuildText:
                        channel = (TextChannel)json.Channels[i];
                        break;
                    case ChannelTypes.GuildVoice:
                        channel = (VoiceChannel)json.Channels[i];
                        break;
                    case ChannelTypes.GuildCategory:
                        channel = (GuildCategory)json.Channels[i];
                        break;
                    case ChannelTypes.GuildNews:
                        channel = (GuildNews)json.Channels[i];
                        break;
                    case ChannelTypes.GuildStore:
                        channel = (GuildStore)json.Channels[i];
                        break;
                }

                channel.GuildId = guild.Id;

                channel.PermissionOverwrites = new PermissionOverwriteCollection(cacheConfig.GetCache<PermissionOverwrite>());

                Parallel.For(0, json.Channels[i].PermissionOverwrites.Length, j =>
                {
                    PermissionOverwrite overwrite = json.Channels[i].PermissionOverwrites[j];

                    channel.PermissionOverwrites.Caching(ref overwrite);
                });

                client.Channels.Caching(ref channel);
                guild.Channels.Caching(ref channel);
            });

            Task.Run(() =>
            {
                for (int i = 0; i < json.Channels.Length; i++)
                {
                    if (json.Channels[i].ParentId != null)
                    {
                        client.Channels[json.Channels[i].Id].Parent = (GuildCategory)client.Channels[(ulong)json.Channels[i].ParentId];
                    }
                }
            });

            client.Guilds.Caching(ref guild);

            return guild;
        }
    }
}
