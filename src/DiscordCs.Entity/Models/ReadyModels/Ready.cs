using FarDragi.DiscordCs.Entity.Interfaces;
using FarDragi.DiscordCs.Entity.Models.ApplicationModels;
using FarDragi.DiscordCs.Entity.Models.GuildModels;
using FarDragi.DiscordCs.Entity.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.ReadyModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#ready-ready-event-fields
    /// </summary>
    public class Ready
    {
        [JsonPropertyName("v")]
        public int Vesion { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; }

        [JsonPropertyName("guilds")]
        public GuildUnavailable[] Guilds { get; set; }

        [JsonPropertyName("session_id")]
        public string SessionId { get; set; }

        [JsonPropertyName("shard")]
        public int[] Shard { get; set; }

        [JsonPropertyName("application")]
        public Application Application { get; set; }
    }
}
