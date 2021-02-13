using FarDragi.DiscordCs.Json.Entities.ChannelModels;

namespace FarDragi.DiscordCs.Entities.ChannelModels
{
    public class VoiceChannel : Channel
    {
        public int Bitrate { get; set; }
        public int UserLimit { get; set; }

        public VoiceChannel()
        {
            Type = ChannelTypes.GuildVoice;
        }

        public static explicit operator VoiceChannel(JsonChannel json)
        {
            return new VoiceChannel
            {
                Id = json.Id,
                Name = json.Name,
                GuildId = json.GuildId,
                LastPinTimestamp = json.LastPinTimestamp,
                Nsfw = json.Nsfw,
                ParentId = json.ParentId,
                Position = json.Position,
                Type = (ChannelTypes)json.Type,
                Bitrate = json.Bitrate,
                UserLimit = json.UserLimit
            };
        }
    }
}
