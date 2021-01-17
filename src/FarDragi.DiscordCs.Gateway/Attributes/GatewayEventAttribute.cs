using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Gateway.Attributes
{
    sealed public class GatewayEventAttribute : Attribute
    {
        private readonly string name;

        public GatewayEventAttribute(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }
    }
}
