using FarDragi.DiscordCs.Json.Entities.PermissionModels;
using FarDragi.DiscordCs.Json.Entities.UserModels;
using Newtonsoft.Json;
using System;

namespace FarDragi.DiscordCs.Json.Entities.ChannelModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#channel-object-channel-structure
    /// </summary>
    public class JsonChannel
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("guild_id")]
        public ulong GuildId { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("permission_overwrites")]
        public JsonPermissionOverwrite[] PermissionOverwrites { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("nsfw")]
        public bool Nsfw { get; set; }

        [JsonProperty("last_message_id")]
        public ulong? LastMessageId { get; set; }

        [JsonProperty("bitrate")]
        public int Bitrate { get; set; }

        [JsonProperty("user_limit")]
        public int UserLimit { get; set; }

        [JsonProperty("rate_limit_per_user")]
        public int RateLimitPerUser { get; set; }

        [JsonProperty("recipients")]
        public JsonUser[] Recipients { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("owner_id")]
        public ulong OwnerId { get; set; }

        [JsonProperty("application_id")]
        public ulong? ApplicationId { get; set; }

        [JsonProperty("parent_id")]
        public ulong? ParentId { get; set; }

        [JsonProperty("last_pin_timestamp")]
        public DateTime LastPinTimestamp { get; set; }
    }
}
