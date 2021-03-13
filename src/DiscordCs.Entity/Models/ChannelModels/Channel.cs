using FarDragi.DiscordCs.Entity.Collections;
using FarDragi.DiscordCs.Entity.Models.PermissionModels;
using FarDragi.DiscordCs.Entity.Models.UserModels;
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

        [JsonPropertyName("application_id")]
        protected ulong? _applicationId { get; set; } // Não sei aonde isso vai parar

        [JsonPropertyName("last_pin_timestamp")]
        protected DateTime? _lastPinTimestamp { get; set; } // Não sei aonde isso via parar
    }
}
