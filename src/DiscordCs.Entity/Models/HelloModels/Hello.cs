using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.HelloModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#hello-hello-structure
    /// </summary>
    public class Hello
    {
        [JsonPropertyName("heartbeat_interval")]
        public int HeartbeatInterval { get; set; }
    }
}
