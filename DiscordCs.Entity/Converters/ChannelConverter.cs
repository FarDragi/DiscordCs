using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entity.Collections;
using FarDragi.DiscordCs.Entity.Models.ChannelModels;
using FarDragi.DiscordCs.Entity.Models.MessageModels;
using FarDragi.DiscordCs.Logging;
using FarDragi.DiscordCs.Rest;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Converters
{
    public class ChannelConverter : JsonConverter<Channel>
    {
        private readonly ICacheContext _cacheContext;
        private readonly IRestContext _restContext;
        private readonly ILogger _logger;

        public ChannelConverter(ICacheContext cacheContext, IRestContext restContext, ILogger logger)
        {
            _cacheContext = cacheContext;
            _restContext = restContext;
            _logger = logger;
        }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(Channel) == typeToConvert;
        }

        public override Channel Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            JsonDocument document = JsonDocument.ParseValue(ref reader);

            Channel channel = null;

            switch (document.RootElement.GetProperty("type").ToObject<ChannelTypes>(options))
            {
                case ChannelTypes.DmChannel:
                case ChannelTypes.DmGroup:
                case ChannelTypes.StoreChannel:
                case ChannelTypes.NewsChannel:
                case ChannelTypes.TextChannel:
                    channel = document.ToObject<TextChannel>(options);
                    (channel as TextChannel).Messages = new MessageCollection(_cacheContext.GetCache<ulong, Message>(), _restContext, options, _logger, channel.Id);
                    break;
                case ChannelTypes.VoiceChannel:
                    channel = document.ToObject<VoiceChannel>(options);
                    break;
                case ChannelTypes.GuildCategory:
                    channel = document.ToObject<GuildCategory>(options);
                    break;
                default:
                    break;
            }

            return channel;
        }

        public override void Write(Utf8JsonWriter writer, Channel value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value);
        }
    }
}
