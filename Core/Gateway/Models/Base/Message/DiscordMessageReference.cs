using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Core.Gateway.Models.Base.Message
{
    internal class DiscordMessageReference
    {
        // Discord DiscordMessageReference
        [JsonProperty("message_id")]
        internal ulong MessageId { get; set; }

        // Discord DiscordMessageReference
        [JsonProperty("channel_id")]
        internal ulong ChannelId { get; set; }

        // Discord DiscordMessageReference
        [JsonProperty("guild_id")]
        internal ulong GuildId { get; set; }
    }
}
