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
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public int LargeThreshold 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public int[] Shard 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public IPresenceStatusUpdate Presence 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public bool GuildSubscriptions 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public int Intents 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
    }
}
