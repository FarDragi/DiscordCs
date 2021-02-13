using FarDragi.DiscordCs.Json.Entities.ChannelModels;

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
