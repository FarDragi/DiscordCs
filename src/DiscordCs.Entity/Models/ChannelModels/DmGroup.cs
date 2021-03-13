using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.ChannelModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#channel-object-example-group-dm-channel
    /// </summary>
    public class DmGroup : PrivateChannel
    {
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("owner_id")]
        public ulong OwnerId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
