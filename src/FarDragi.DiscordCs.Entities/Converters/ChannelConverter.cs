using FarDragi.DiscordCs.Entities.ChannelModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.Converters
{
    class ChannelConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Channel);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            JObject obj = JObject.Load(reader);

            switch (obj["type"].ToObject<ChannelTypes>())
            {
                case ChannelTypes.GuildNews:
                case ChannelTypes.GuildStore:
                case ChannelTypes.GuildText:
                    return obj.ToObject<TextChannel>();
                case ChannelTypes.GuildVoice:
                    return obj.ToObject<VoiceChannel>();
                case ChannelTypes.GuildCategory:
                    return obj.ToObject<GuildCategory>();
                default:
                    return null;
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}
