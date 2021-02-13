using FarDragi.DiscordCs.Entities.ChannelModels;
using FarDragi.DiscordCs.Json.Entities.ChannelModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.ChannelModels
{
    public class GuildStore : Channel
    {
        public static explicit operator GuildStore(JsonChannel json)
        {
            return new GuildStore
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
            };
        }
    }
}
