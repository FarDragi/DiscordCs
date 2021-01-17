using FarDragi.DiscordCs.Json.Entities.EmojiModels;
using FarDragi.DiscordCs.Json.Entities.MemberModels;
using FarDragi.DiscordCs.Json.Entities.RoleModels;
using FarDragi.DiscordCs.Json.Entities.VoiceModels;
using Newtonsoft.Json;
using System;

namespace FarDragi.DiscordCs.Json.Entities.GuildModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/guild#guild-object-guild-structure
    /// </summary>
    public class JsonGuild
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("icon_hash")]
        public string IconHash { get; set; }

        [JsonProperty("splash")]
        public string Splash { get; set; }

        [JsonProperty("discovery_splash")]
        public string DiscoverySplash { get; set; }

        [JsonProperty("owner")]
        public bool Owner { get; set; }

        [JsonProperty("owner_id")]
        public ulong OwnerId { get; set; }

        [JsonProperty("permissions")]
        public string Permissions { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("afk_channel_id")]
        public ulong? AfkChannelId { get; set; }

        [JsonProperty("afk_timeout")]
        public int AfkTimeout { get; set; }

        [JsonProperty("widget_enabled")]
        public bool WidgetEnabled { get; set; }

        [JsonProperty("widget_channel_id")]
        public ulong? WidgetChannelId { get; set; }

        [JsonProperty("verification_level")]
        public int VerificationLevel { get; set; }

        [JsonProperty("default_message_notifications")]
        public int DefaultMessageNotifications { get; set; }

        [JsonProperty("explicit_content_filter")]
        public int ExplicitContentFilter { get; set; }

        [JsonProperty("roles")]
        public JsonRole[] Roles { get; set; }

        [JsonProperty("emojis")]
        public JsonEmoji[] Emojis { get; set; }

        [JsonProperty("features")]
        public string[] Features { get; set; }

        [JsonProperty("mfa_level")]
        public int MfaLevel { get; set; }

        [JsonProperty("application_id")]
        public ulong? ApplicationId { get; set; }

        [JsonProperty("system_channel_id")]
        public ulong SystemChannelId { get; set; }

        [JsonProperty("system_channel_flags")]
        public int SystemChannelFlags { get; set; }

        [JsonProperty("rules_channel_id")]
        public ulong? RulesChannelId { get; set; }

        [JsonProperty("joined_at")]
        public DateTime? JoinedAt { get; set; }

        [JsonProperty("large")]
        public bool Large { get; set; }

        [JsonProperty("unavailable")]
        public bool Unavailable { get; set; }

        [JsonProperty("member_count")]
        public int MemberCount { get; set; }

        [JsonProperty("voice_states")]
        public JsonVoice[] Voices { get; set; }

        [JsonProperty("members")]
        public JsonMember[] Members { get; set; }
        public IDiscordChannel[] Channels { get; set; }
        public IDiscordPresence[] Presences { get; set; }
        public int MaxPresences { get; set; }
        public int MaxMembers { get; set; }
        public string VanityUrlCode { get; set; }
        public string Description { get; set; }
        public string Banner { get; set; }
        public int PremiumTier { get; set; }
        public int PremiumSubscriptionCount { get; set; }
        public string PreferredLocale { get; set; }
        public ulong PublicUpdatesChannelId { get; set; }
        public int MaxVideoChannelUsers { get; set; }
        public int ApproximateMemberCount { get; set; }
        public int ApproximatePresenceCount { get; set; }
    }
}
