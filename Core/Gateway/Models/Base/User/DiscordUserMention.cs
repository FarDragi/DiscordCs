using FarDragi.DiscordCs.Core.Gateway.Models.Base.Member;
using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.User
{
    internal class DiscordUserMention : DiscordUser
    {
        [JsonProperty("member")]
        internal DiscordMember Member { get; set; }
    }
}
