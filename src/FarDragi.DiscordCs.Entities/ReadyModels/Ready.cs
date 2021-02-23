using FarDragi.DiscordCs.Entities.ApplicationModels;
using FarDragi.DiscordCs.Entities.GuildModels;
using FarDragi.DiscordCs.Entities.UserModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.ReadyModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#ready-ready-event-fields
    /// </summary>
    public class Ready
    {
        [JsonProperty("v")]
        public int Vesion { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("guilds")]
        public GuildUnavailable[] Guilds { get; set; }

        [JsonProperty("session_id")]
        public string SessionId { get; set; }

        [JsonProperty("shard")]
        public int[] Shard { get; set; }

        [JsonProperty("application")]
        public Application Application { get; set; }
    }
}
