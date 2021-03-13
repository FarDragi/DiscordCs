using System;
using System.Buffers;
using System.Text.Json;

namespace FarDragi.DiscordCs.Entity.Converters
{
    public static class ToObjectConverter
    {
        public static TEntity ToObject<TEntity>(this JsonElement element, JsonSerializerOptions options = null)
        {
            ArrayBufferWriter<byte> bufferWriter = new ArrayBufferWriter<byte>();
            using (var writer = new Utf8JsonWriter(bufferWriter))
            {
                element.WriteTo(writer);
            }
            return JsonSerializer.Deserialize<TEntity>(bufferWriter.WrittenSpan, options);
        }

        public static TEntity ToObject<TEntity>(this JsonDocument document, JsonSerializerOptions options = null)
        {
            if (document == null)
            {
                throw new ArgumentNullException(nameof(document));
            }
            return document.RootElement.ToObject<TEntity>(options);
        }
    }
}
