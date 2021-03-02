using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.GuildModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/guild#unavailable-guild-object
    /// </summary>
    public class GuildUnavailable
    {
        [JsonPropertyName("id")]
        public ulong Id { get; set; }

        [JsonPropertyName("unavailable")]
        public bool Unavailable { get; set; }
    }
}
