using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Message
{
    internal class DiscordMessageReference
    {
        [JsonProperty("message_id")]
        internal ulong MessageId { get; set; }

        [JsonProperty("channel_id")]
        internal ulong ChannelId { get; set; }

        [JsonProperty("guild_id")]
        internal ulong GuildId { get; set; }
    }
}
