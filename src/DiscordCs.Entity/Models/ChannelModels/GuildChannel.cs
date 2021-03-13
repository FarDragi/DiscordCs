using FarDragi.DiscordCs.Entity.Models.PermissionModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Models.ChannelModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#channel-object-channel-structure
    /// </summary>
    [DebuggerDisplay("({Id, nq}) {Name, nq}")]
    public class GuildChannel : Channel
    {
        [JsonPropertyName("guild_id")]
        public ulong GuildId { get; set; }

        [JsonPropertyName("position")]
        public int Position { get; set; }

        [JsonPropertyName("permission_overwrites")]
        public PermissionOverwrite[] PermissionOverwrites { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("nsfw")]
        public bool IsNfsw { get; set; }

        [JsonPropertyName("parent_id")]
        public ulong? ParentId { get; set; }
    }
}
