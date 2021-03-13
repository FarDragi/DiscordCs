using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entity.Collections;
using FarDragi.DiscordCs.Entity.Models.ChannelModels;
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

        public ChannelCollectionConverter(ICacheContext cacheContext)
        {
            _cacheContext = cacheContext;
        }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(ChannelCollection).IsAssignableFrom(typeToConvert);
        }

        public override ChannelCollection Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            ChannelCollection channelCollection = new ChannelCollection(_cacheContext.GetCache<ulong, Channel>());
            JsonDocument document = JsonDocument.ParseValue(ref reader);
            Channel[] channels = document.ToObject<Channel[]>(options);
            for (int i = 0; i < channels.Length; i++)
            {
                channelCollection.Caching(ref channels[i]);
            }

            return channelCollection;
        }

        public override void Write(Utf8JsonWriter writer, ChannelCollection value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, (IEnumerable<Channel>)value);
        }
    }
}
