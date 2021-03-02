using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Converters
{
    public class ToULongConverter : JsonConverter<ulong>
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(ulong).IsAssignableFrom(typeToConvert);
        }

        public override ulong Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (ulong.TryParse(reader.GetString(), out ulong result))
            {
                return result;
            }

            return 0;
        }

        public override void Write(Utf8JsonWriter writer, ulong value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
