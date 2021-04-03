using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entity.Collections;
using FarDragi.DiscordCs.Entity.Interfaces;
using FarDragi.DiscordCs.Entity.Models.ChannelModels;
using FarDragi.DiscordCs.Logging;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Converters
{
    public class GuildChannelCollectionConverter : JsonConverter<GuildChannelsCollection>
    {
        private readonly ICacheContext _cacheContext;
        private readonly IDatas _datas;
        private readonly ILogger _logger;

        public GuildChannelCollectionConverter(ICacheContext cacheContext, IDatas datas, ILogger logger)
        {
            _cacheContext = cacheContext;
            _datas = datas;
            _logger = logger;
        }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(GuildChannelsCollection) == typeToConvert;
        }

        public override GuildChannelsCollection Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            GuildChannelsCollection channelCollection = new GuildChannelsCollection(_cacheContext.GetCache<ulong, GuildChannel>(), _logger);
            JsonDocument document = JsonDocument.ParseValue(ref reader);
            Span<GuildChannel> channels = document.ToObject<GuildChannel[]>(options);
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

        public override void Write(Utf8JsonWriter writer, GuildChannelsCollection value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, (IEnumerable<GuildChannel>)value);
        }
    }
}
