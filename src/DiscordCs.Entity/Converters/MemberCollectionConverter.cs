using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entity.Collections;
using FarDragi.DiscordCs.Entity.Models.MemberModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Converters
{
    public class MemberCollectionConverter : JsonConverter<MemberCollection>
    {
        private readonly ICacheContext _cacheContext;

        public MemberCollectionConverter(ICacheContext cacheContext)
        {
            _cacheContext = cacheContext;
        }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(MemberCollection) == typeToConvert;
        }

        public override MemberCollection Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            MemberCollection memberCollection = new MemberCollection(_cacheContext.GetCache<ulong, Member>());
            JsonDocument document = JsonDocument.ParseValue(ref reader);
            Member[] members = document.ToObject<Member[]>(options);
            for (int i = 0; i < members.Length; i++)
            {
                memberCollection.Caching(ref members[i]);
            }

            return memberCollection;
        }

        public override void Write(Utf8JsonWriter writer, MemberCollection value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, (IEnumerable<Member>)value);
        }
    }
}
