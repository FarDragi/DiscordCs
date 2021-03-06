﻿using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Json.Entities.GuildModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/guild#unavailable-guild-object
    /// </summary>
    public class JsonGuildUnavailable
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("unavailable")]
        public bool Unavailable { get; set; }
    }
}
