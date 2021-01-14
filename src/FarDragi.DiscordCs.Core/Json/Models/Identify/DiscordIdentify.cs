using FarDragi.DiscordCs.Core.Interfaces.Identify;
using FarDragi.DiscordCs.Core.Interfaces.Presence;
using FarDragi.DiscordCs.Core.Json.Convertes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Json.Models.Identify
{
    public class DiscordIdentify : IDiscordIdentify
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("properties")]
        [JsonConverter(typeof(ConcreteTypeConverter<IdentifyProperties>))]
        public IIdentifyProperties Properties { get; set; }

        [JsonProperty("compress")]
        public bool Compress { get; set; } = true;

        [JsonProperty("large_threshold")]
        public int LargeThreshold { get; set; } = 250;

        [JsonProperty("shard")]
        public int[] Shard { get; set; }

        [JsonProperty("presence")]
        public IPresenceStatusUpdate Presence { get; set; }

        [JsonProperty("guild_subscriptions")]
        public bool GuildSubscriptions { get; set; } = true;

        [JsonProperty("intents")]
        public int Intents { get; set; }
    }
}
