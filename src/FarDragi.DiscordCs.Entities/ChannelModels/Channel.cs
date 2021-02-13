using FarDragi.DiscordCs.Entities.PermissionModels;
using FarDragi.DiscordCs.Entities.UserModels;
using FarDragi.DiscordCs.Json.Entities.ChannelModels;
using System;

namespace FarDragi.DiscordCs.Entities.ChannelModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#channel-object-channel-structure
    /// </summary>
    public class Channel
    {
        public ulong Id { get; set; }
        public ChannelTypes Type { get; set; }
        public ulong GuildId { get; set; }
        public int Position { get; set; }
        public PermissionOverwrite[] PermissionOverwrites { get; set; }
        public string Name { get; set; }
        public bool Nsfw { get; set; }
        public ulong ApplicationId { get; set; }
        public ulong ParentId { get; set; }
        public DateTime LastPinTimestamp { get; set; }

        public static implicit operator Channel(JsonChannel json)
        {
            return new Channel
            {
                Id = json.Id,
                Name = json.Name,
                ApplicationId = json.ApplicationId,
                GuildId = json.GuildId,
                LastPinTimestamp = json.LastPinTimestamp,
                Nsfw = json.Nsfw,
                ParentId = json.ParentId,
                Position = json.Position,
                Type = (ChannelTypes)json.Type,
            };
        }
    }
}
