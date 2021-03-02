using FarDragi.DiscordCs.Entity.Models.PermissionModels;
using FarDragi.DiscordCs.Entity.Models.UserModels;
using System;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.ChannelModels
{
    public class Channel
    {
        [JsonPropertyName("id")]
        public ulong Id { get; set; }

        [JsonPropertyName("type")]
        public ChannelTypes Type { get; set; }

        [JsonPropertyName("guild_id")]
        public ulong GuildId { get; set; }

        [JsonPropertyName("position")]
        public int Position { get; set; }

        [JsonPropertyName("permission_overwrites")]
        public PermissionOverwrite[] PermissionOverwrites { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("topic")]
        public string Topic { get; set; }

        [JsonPropertyName("nsfw")]
        public bool IsNsfw { get; set; }

        [JsonPropertyName("last_message_id")]
        public ulong? LastMessageId { get; set; }

        [JsonPropertyName("bitrate")]
        public int Bitrate { get; set; }

        [JsonPropertyName("user_limit")]
        public int UserLimit { get; set; }

        [JsonPropertyName("rate_limit_per_user")]
        public int RateLimitPerUser { get; set; }

        [JsonPropertyName("recipients")]
        public User[] Recipients { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("owner_id")]
        public ulong OwnerId { get; set; }

        [JsonPropertyName("application_id")]
        public ulong? ApplicationId { get; set; }

        [JsonPropertyName("parent_id")]
        public ulong? ParentId { get; set; }

        [JsonPropertyName("last_pin_timestamp")]
        public DateTime LastPinTimestamp { get; set; }
    }
}
