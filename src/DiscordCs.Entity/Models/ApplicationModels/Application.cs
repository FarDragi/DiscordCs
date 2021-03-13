using FarDragi.DiscordCs.Entity.Models.TeamModels;
using FarDragi.DiscordCs.Entity.Models.UserModels;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.ApplicationModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/oauth2#application-object
    /// </summary>
    public class Application
    {
        [JsonPropertyName("id")]
        public ulong Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("rpc_origins")]
        public string[] RpcOrigins { get; set; }

        [JsonPropertyName("bot_public")]
        public bool IsBotPublic { get; set; }

        [JsonPropertyName("bot_require_code_grant")]
        public bool IsBotRequireCodeGrant { get; set; }

        [JsonPropertyName("owner")]
        public User Owner { get; set; }

        [JsonPropertyName("summary")]
        public string Summary { get; set; }

        [JsonPropertyName("verify_key")]
        public string VerifyKey { get; set; }

        [JsonPropertyName("team")]
        public Team Team { get; set; }

        [JsonPropertyName("guild_id")]
        public ulong? GuildId { get; set; }

        [JsonPropertyName("primary_sku_id")]
        public ulong? PrimarySkuId { get; set; }

        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonPropertyName("cover_image")]
        public string CoverImage { get; set; }

        [JsonPropertyName("flags")]
        public int Flags { get; set; }
    }
}
