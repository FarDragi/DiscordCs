using FarDragi.DiscordCs.Core.Gateway.Models.Base;
using FarDragi.DiscordCs.Core.Gateway.Models.Base.User;
using FarDragi.DiscordCs.Core.Models.Base.Guild;
using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Events
{
    internal sealed class EventReady
    {
        [JsonProperty("v")]
        public uint Version { get; set; }

        [JsonProperty("user")]
        public DiscordUser User { get; set; }

        // Eu n sei oq fazer com isso pq isso é literalmente vazio
        //[JsonProperty("private_channels")]
        //public object[] PrivateChannels { get; set; }

        [JsonProperty("guilds")]
        public DiscordGuild[] Guilds { get; set; }

        [JsonProperty("session_id")]
        public string SessionId { get; set; }

        [JsonProperty("shard")]
        public uint[] Shard { get; set; }
    }
}
