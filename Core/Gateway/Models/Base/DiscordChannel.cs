using FarDragi.DiscordCs.Core.Gateway.Models.Enumerators;
using Newtonsoft.Json;
using System;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base
{
    internal class DiscordChannel
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("type")]
        public DiscordChannelType Type { get; set; }

        [JsonProperty("guild_id")]
        public ulong GuildId { get; set; }

        [JsonProperty("position")]
        public uint Position { get; set; }

        [JsonProperty("permission_overwrites")]
        public DiscordChannelOverrites[] PermissionOverwrites { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("nsfw")]
        public bool IsNsfw { get; set; }

        [JsonProperty("last_message_id")]
        public ulong LastMessageId { get; set; }

        [JsonProperty("bitrate")]
        public uint Bitrate { get; set; }

        [JsonProperty("user_limit")]
        public uint UserLimit { get; set; }

        [JsonProperty("rate_limit_per_user")]
        public uint RateLimitPerUser { get; set; }

        [JsonProperty("recipients")]
        public DiscordUser[] Recipients { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("owner_id")]
        public ulong OwnerId { get; set; }

        [JsonProperty("application_id")]
        public ulong ApplicationId { get; set; }

        [JsonProperty("parent_id")]
        public ulong? ParentId { get; set; }

        [JsonProperty("last_pin_timestamp")]
        public DateTime LastPinTimestamp { get; set; }
    }
}
