using FarDragi.DiscordCs.Core.Identify;
using FarDragi.DiscordCs.Core.Presence;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Gateway.Models.Identify
{
    public class DiscordIdentify : IDiscordIdentify
    {
        [JsonProperty("token")]
        private string token;

        [JsonProperty("properties")]
        private IdentifyProperties properties;

        [JsonProperty("compress")]
        private bool compress;

        [JsonProperty("large_threshold")]
        private int largeThreshold;

        [JsonProperty("shard")]
        private int[] shard;

        [JsonProperty("intents")]
        private int intents;

        public string Token 
        { 
            get => token; 
            set => token = value; 
        }

        public IIdentifyProperties Properties 
        { 
            get => properties; 
            set => properties = (IdentifyProperties)value; 
        }

        public bool Compress 
        {
            get => compress;
            set => compress = value; 
        }

        public int LargeThreshold 
        {
            get => largeThreshold;
            set => largeThreshold = value;
        }

        public int[] Shard 
        {
            get => shard;
            set => shard = value;
        }

        public IPresenceStatusUpdate Presence 
        {
            get;
            set;
        }

        public bool GuildSubscriptions 
        {
            get;
            set;
        }

        public int Intents 
        {
            get => intents;
            set => intents = value;
        }
    }
}
