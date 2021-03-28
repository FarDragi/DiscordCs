using FarDragi.DiscordCs.Entity.Models.InteractionModels;
using FarDragi.DiscordCs.Entity.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.MessageModels
{
    /// <summary>
    /// https://discord.com/developers/docs/interactions/slash-commands#messageinteraction
    /// </summary>
    public class MessageInteraction
    {
        [JsonPropertyName("id")]
        public ulong Id { get; set; }

        [JsonPropertyName("type")]
        public InteractionTypes Type { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; }
    }
}
