using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entity.Models.MessageModels
{
    public class MessageUpdate
    {
        public Message Message { get; set; }
        public Message OldMessage { get; set; }
    }
}
