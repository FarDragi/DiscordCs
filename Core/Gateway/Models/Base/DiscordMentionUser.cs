using FarDragi.DiscordCs.Core.Gateway.Models.Base.Member;
using FarDragi.DiscordCs.Core.Gateway.Models.Base.User;
using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base
{
    internal class DiscordMentionUser : DiscordUser
    {
        [JsonProperty("member")]
        internal DiscordMember Member { get; set; }
    }
}
