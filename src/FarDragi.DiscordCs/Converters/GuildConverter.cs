using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entities.ChannelModels;
using FarDragi.DiscordCs.Entities.GuildModels;
using FarDragi.DiscordCs.Entities.MemberModels;
using FarDragi.DiscordCs.Entities.PermissionModels;
using FarDragi.DiscordCs.Entities.RoleModels;
using FarDragi.DiscordCs.Entities.UserModels;
using FarDragi.DiscordCs.Json.Entities.GuildModels;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Converters
{
    public static class GuildConverter
    {
        public static Guild ToGuild(this JsonGuild json, ICacheConfig cacheConfig, Client client)
        {
            Guild guild = json;

            guild.Roles = new RoleCollection(cacheConfig.GetCache<Role>());

            Parallel.For(0, json.Roles.Length, i =>
            {
                Role role = json.Roles[i];

                if (json.Roles[i].Tags != null)
                {
                    role.Tags = json.Roles[i].Tags;
                }

                guild.Roles.Caching(ref role);
            });

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

            Parallel.For(0, json.Channels.Length, i =>
            {
                if (json.Channels[i].ParentId != null)
                {
                    client.Channels[json.Channels[i].Id].Parent = (GuildCategory)client.Channels[(ulong)json.Channels[i].ParentId];
                }
            });

            guild.Members = new MemberCollection(cacheConfig.GetCache<Member>());

            Parallel.For(0, json.Members.Length, i =>
            {
                User user = json.Members[i].User;

                client.Users.Caching(ref user);

                Member member = json.Members[i];
                member.User = user;

                guild.Members.Caching(ref member);
            });

            client.Guilds.Caching(ref guild);

            return guild;
        }
    }
}
