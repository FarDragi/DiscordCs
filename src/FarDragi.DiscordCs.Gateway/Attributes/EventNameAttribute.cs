using System;

namespace FarDragi.DiscordCs.Gateway.Attributes
{
    sealed public class EventNameAttribute : Attribute
    {
        private readonly string name;

        public EventNameAttribute(string name)
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
