using FarDragi.DiscordCs.Entities.PermissionModels;
using Newtonsoft.Json;
using System;

namespace FarDragi.DiscordCs.Entities.ChannelModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#channel-object-channel-structure
    /// </summary>
    public class Channel
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("type")]
        public ChannelTypes Type { get; set; }

        [JsonProperty("guild_id")]
        public ulong GuildId { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("permission_overwrites")]
        private PermissionOverwrite[] _permissionOverwrites { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nsfw")]
        public bool Nsfw { get; set; }

        [JsonProperty("parent_id")]
        public ulong? ParentId { get; set; }

        [JsonIgnore]
        public GuildCategory Parent { get; set; }

        [JsonProperty("last_pin_timestamp")]
        public DateTime LastPinTimestamp { get; set; }

        [JsonIgnore]
        public PermissionOverwriteCollection PermissionOverwrites { get; set; }
    }
}
