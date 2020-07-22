using FarDragi.DiscordCs.Core.Gateway.Models.Base.User;
using FarDragi.DiscordCs.Core.Gateway.Models.Enums.Channel;
using Newtonsoft.Json;
using System;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Channel
{
    internal class DiscordChannel
    {
        // Discord Channel
        [JsonProperty("id")]
        internal ulong Id { get; set; }

        // Discord Channel
        [JsonProperty("type")]
        internal DiscordChannelType Type { get; set; }

        // Discord Channel Guild
        [JsonProperty("guild_id")]
        internal ulong GuildId { get; set; }

        // Discord Channel Guild
        [JsonProperty("position")]
        internal uint Position { get; set; }

        [JsonProperty("permission_overwrites")]
        internal DiscordChannelOverrites[] PermissionOverwrites { get; set; }

        // Discord Channel
        [JsonProperty("name")]
        internal string Name { get; set; }

        // Discord Channel Guild Text
        [JsonProperty("topic")]
        internal string Topic { get; set; }

        // Discord Channel Guild Text
        [JsonProperty("nsfw")]
        internal bool IsNsfw { get; set; }

        // Discord Channel Guild Text
        [JsonProperty("last_message_id")]
        internal ulong LastMessageId { get; set; }

        // Discord Channel Guild Voice
        [JsonProperty("bitrate")]
        internal uint Bitrate { get; set; }

        // Discord Channel Guild Voice
        [JsonProperty("user_limit")]
        internal uint UserLimit { get; set; }

        // Discord Channel Guild Text
        [JsonProperty("rate_limit_per_user")]
        internal uint RateLimitPerUser { get; set; }

        [JsonProperty("recipients")]
        internal DiscordUser[] Recipients { get; set; }

        [JsonProperty("icon")]
        internal string Icon { get; set; }

        [JsonProperty("owner_id")]
        internal ulong OwnerId { get; set; }

        [JsonProperty("application_id")]
        internal ulong ApplicationId { get; set; }

        // Discord Channel Guild
        [JsonProperty("parent_id")]
        internal ulong? ParentId { get; set; }

        [JsonProperty("last_pin_timestamp")]
        internal DateTime LastPinTimestamp { get; set; }
    }
}
