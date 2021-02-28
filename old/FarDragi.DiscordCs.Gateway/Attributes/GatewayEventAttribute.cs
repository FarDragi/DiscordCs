using System;

namespace FarDragi.DiscordCs.Gateway.Attributes
{
    sealed public class GatewayEventAttribute : Attribute
    {
        private readonly string _name;
        private readonly Type _type;

        public GatewayEventAttribute(string name, Type type)
        {
            _name = name;
            _type = type;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public Type Type
        {
            get
            {
                return _type;
            }
        }
    }
}
