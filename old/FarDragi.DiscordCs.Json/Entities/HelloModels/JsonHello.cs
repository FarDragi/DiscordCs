using Newtonsoft.Json;

namespace FarDragi.DiscordCs.Json.Entities.HelloModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#hello-hello-structure
    /// </summary>
    public class JsonHello
    {
        [JsonProperty("heartbeat_interval")]
        public int HeartbeatInterval { get; set; }
    }
}
