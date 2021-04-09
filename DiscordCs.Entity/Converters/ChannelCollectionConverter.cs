using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entity.Collections;
using FarDragi.DiscordCs.Entity.Interfaces;
using FarDragi.DiscordCs.Entity.Models.ChannelModels;
using FarDragi.DiscordCs.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Converters
{
    public class ChannelCollectionConverter : JsonConverter<ChannelCollection> 
    {
        private readonly ICacheContext _cacheContext;
        private readonly IDatas _datas;
        private readonly ILogger _logger;

        public ChannelCollectionConverter(ICacheContext cacheContext, IDatas datas, ILogger logger)
        {
            _cacheContext = cacheContext;
            _datas = datas;
            _logger = logger;
        }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(ChannelCollection) == typeToConvert;
        }

        public override ChannelCollection Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            ChannelCollection channelCollection = new ChannelCollection(_cacheContext.GetCache<ulong, Channel>(), _logger);
            JsonDocument document = JsonDocument.ParseValue(ref reader);
            Span<Channel> channels = document.ToObject<Channel[]>(options);
            for (int i = 0; i < channels.Length; i++)
            {
                if (channels[i] == null)
                {
                    continue;
                }

                channelCollection.Caching(ref channels[i]);
                _datas.Channels.Caching(ref channels[i]);
            }

            return channelCollection;
        }

        public override void Write(Utf8JsonWriter writer, ChannelCollection value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, (IEnumerable<Channel>)value);
        }
    }
}
