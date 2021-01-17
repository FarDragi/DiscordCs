using FarDragi.DiscordCs.Json.Entities.GuildModels;
using FarDragi.DiscordCs.Json.Entities.UserModels;
using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Json.Entities.ReadyModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#ready-ready-event-fields
    /// </summary>
    public class JsonReady
    {
        [JsonProperty("v")]
        public int Vesion { get; set; }

        [JsonProperty("user")]
        public JsonUser User { get; set; }

        [JsonProperty("guilds")]
        public JsonGuild[] Guilds { get; set; }

        [JsonProperty("session_id")]
        public string SessionId { get; set; }

        [JsonProperty("shard")]
        public int[] Shard { get; set; }

        [JsonProperty("application")]
        public IDiscordApplication Application { get; set; }
    }
}
