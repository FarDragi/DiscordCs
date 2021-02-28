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

        public static explicit operator VoiceChannel(BaseChannel channel)
        {
            return new VoiceChannel
            {
                Id = channel.Id,
                Name = channel.Name,
                GuildId = channel.GuildId,
                LastPinTimestamp = channel.LastPinTimestamp,
                Nsfw = channel.Nsfw,
                ParentId = channel.ParentId,
                Position = channel.Position,
                Type = channel.Type,
                Bitrate = channel.Bitrate,
                UserLimit = channel.UserLimit
            };
        }
    }
}
