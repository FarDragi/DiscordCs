using FarDragi.DiscordCs.Entity.Models.PermissionModels;
using System;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.ChannelModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#channel-object-channel-structure
    /// </summary>
    [DebuggerDisplay("({Id, nq}) {Type, nq}")]
    public class Channel
    {
        [JsonPropertyName("id")]
        public ulong Id { get; set; }

        [JsonPropertyName("type")]
        public ChannelTypes Type { get; set; }

        [JsonPropertyName("guild_id")]
        public ulong? GuildId { get; set; }

        [JsonPropertyName("position")]
        public int? Position { get; set; }

        [JsonPropertyName("permission_overwrites")]
        public PermissionOverwrite[] PermissionOverwrites { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("nsfw")]
        public bool? IsNfsw { get; set; }

        [JsonPropertyName("parent_id")]
        public ulong? ParentId { get; set; }

        [JsonPropertyName("application_id")]
        protected ulong? _applicationId { get; set; } // Não sei aonde isso vai parar

        [JsonPropertyName("last_pin_timestamp")]
        protected DateTime? _lastPinTimestamp { get; set; } // Não sei aonde isso via parar
    }
}
