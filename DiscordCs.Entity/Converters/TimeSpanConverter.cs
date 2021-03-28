using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Converters
{
    public class TimeSpanConverter : JsonConverter<TimeSpan>
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(TimeSpan) == typeToConvert;
        }

        public override TimeSpan Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TryGetInt64(out long result))
            {
                return new TimeSpan(result / 1000);
            }

            return default;
        }

        public override void Write(Utf8JsonWriter writer, TimeSpan value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value.Ticks * 1000);
        }
    }
}
