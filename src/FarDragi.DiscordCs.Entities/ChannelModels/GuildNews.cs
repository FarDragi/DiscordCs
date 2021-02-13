using FarDragi.DiscordCs.Entities.ChannelModels;
using FarDragi.DiscordCs.Json.Entities.ChannelModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.ChannelModels
{
    public class GuildNews : Channel
    {
        public string Topic { get; set; }
        public ulong? LastMessageId { get; set; }

        public static explicit operator GuildNews(JsonChannel json)
        {
            return new GuildNews
            {
                Id = json.Id,
                Name = json.Name,
                ApplicationId = json.ApplicationId,
                GuildId = json.GuildId,
                LastPinTimestamp = json.LastPinTimestamp,
                Nsfw = json.Nsfw,
                ParentId = json.ParentId,
                Position = json.Position,
                Type = (ChannelTypes)json.Type,
                Topic = json.Topic,
                LastMessageId = json.LastMessageId
            };
        }
    }
}
