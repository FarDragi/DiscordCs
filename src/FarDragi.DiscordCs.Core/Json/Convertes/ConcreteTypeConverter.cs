using Newtonsoft.Json;
using System;

namespace FarDragi.DiscordCs.Core.Json.Convertes
{
    public class ConcreteTypeConverter<TType> : JsonConverter where TType : class
    {
        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return serializer.Deserialize<TType>(reader);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}
