﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.ActivityModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#activity-object-activity-party
    /// </summary>
    public class ActivityParty
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("size")]
        public int[] Size { get; set; }
    }
}
