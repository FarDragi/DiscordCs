﻿using FarDragi.DiscordCs.Core.Json.Models.Identify;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Gateway
{
    public class GatewayConfig
    {
        public DiscordIdentifyBase Identify { get; set; }
    }
}
