using FarDragi.DiscordCs.Entities.ChannelModels;
using FarDragi.DiscordCs.Json.Entities.ChannelModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.ChannelModels
{
    public class GuildCategory : Channel
    {
        public GuildCategory()
        {
            Type = ChannelTypes.GuildCategory;
        }

        public static explicit operator GuildCategory(JsonChannel json)
        {
            return new GuildCategory
            {
                Id = json.Id,
                Name = json.Name,
                GuildId = json.GuildId,
                LastPinTimestamp = json.LastPinTimestamp,
                Nsfw = json.Nsfw,
                ParentId = json.ParentId,
                Position = json.Position,
                Type = (ChannelTypes)json.Type
            };
        }
    }
}
