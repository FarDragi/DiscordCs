using FarDragi.DiscordCs.Entities.MemberModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.UserModels
{
    public class UserMention : User
    {
        [JsonProperty("member")]
        public Member MyProperty { get; set; }
    }
}
