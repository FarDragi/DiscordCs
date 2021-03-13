using FarDragi.DiscordCs.Entity.Models.ChannelModels;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Converters
{
    public class GuildChannelConverter : JsonConverter<GuildChannel>
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(GuildChannel) == typeToConvert;
        }

        public override GuildChannel Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            JsonDocument document = JsonDocument.ParseValue(ref reader);

            GuildChannel channel = null;

            switch (document.RootElement.GetProperty("type").ToObject<ChannelTypes>(options))
            {
                case ChannelTypes.TextChannel:
                    channel = document.ToObject<TextChannel>(options);
                    break;
                case ChannelTypes.VoiceChannel:
                    channel = document.ToObject<VoiceChannel>(options);
                    break;
                case ChannelTypes.GuildCategory:
                    channel = document.ToObject<GuildCategory>(options);
                    break;
                case ChannelTypes.NewsChannel:
                    channel = document.ToObject<NewsChannel>(options);
                    break;
                case ChannelTypes.StoreChannel:
                    channel = document.ToObject<StoreChannel>(options);
                    break;
                default:
                    break;
            }

            return channel;
        }

        public override void Write(Utf8JsonWriter writer, GuildChannel value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value);
        }
    }
}
