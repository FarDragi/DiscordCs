using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entity.Collections;
using FarDragi.DiscordCs.Entity.Interfaces;
using FarDragi.DiscordCs.Entity.Models.ChannelModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Converters
{
    public class GuildChannelCollectionConverter : JsonConverter<GuildChannelsCollection>
    {
        private readonly ICacheContext _cacheContext;
        private readonly IDatas _datas;

        public GuildChannelCollectionConverter(ICacheContext cacheContext, IDatas datas)
        {
            _cacheContext = cacheContext;
            _datas = datas;
        }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(GuildChannelsCollection) == typeToConvert;
        }

        public override GuildChannelsCollection Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            GuildChannelsCollection channelCollection = new GuildChannelsCollection(_cacheContext.GetCache<ulong, GuildChannel>());
            JsonDocument document = JsonDocument.ParseValue(ref reader);
            GuildChannel[] channels = document.ToObject<GuildChannel[]>(options);
            for (int i = 0; i < channels.Length; i++)
            {
                channelCollection.Caching(ref channels[i]);
                _datas.Channels.Caching(ref channels[i]);
            }

            return channelCollection;
        }

        public override void Write(Utf8JsonWriter writer, GuildChannelsCollection value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, (IEnumerable<GuildChannel>)value);
        }
    }
}
