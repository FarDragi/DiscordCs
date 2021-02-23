using Newtonsoft.Json;
using System;

namespace FarDragi.DiscordCs.Json.Converters
{
    public class UnixSpanConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(TimeSpan);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return new TimeSpan((long)reader.Value / 1000);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(((TimeSpan)value).Seconds);
        }
    }
}
