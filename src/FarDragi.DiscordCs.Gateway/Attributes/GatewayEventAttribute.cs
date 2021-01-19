using System;

namespace FarDragi.DiscordCs.Gateway.Attributes
{
    sealed public class GatewayEventAttribute : Attribute
    {
        private readonly string name;
        private readonly Type type;

        public GatewayEventAttribute(string name, Type type)
        {
            this.name = name;
            this.type = type;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public Type Type
        {
            get
            {
                return type;
            }
        }
    }
}
