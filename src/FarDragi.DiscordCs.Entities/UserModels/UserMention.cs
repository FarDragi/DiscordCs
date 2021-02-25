using FarDragi.DiscordCs.Entities.MemberModels;
using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Entities.UserModels
{
    public class UserMention : User
    {
        [JsonProperty("member")]
        public Member MyProperty { get; set; }
    }
}
