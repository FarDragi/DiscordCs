using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entity.Collections;
using FarDragi.DiscordCs.Entity.Interfaces;
using FarDragi.DiscordCs.Entity.Models.MemberModels;
using FarDragi.DiscordCs.Entity.Models.UserModels;
using FarDragi.DiscordCs.Logging;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Converters
{
    public class MemberCollectionConverter : JsonConverter<MemberCollection>
    {
        private readonly ICacheContext _cacheContext;
        private readonly IDatas _datas;
        private readonly ILogger _logger;

        public MemberCollectionConverter(ICacheContext cacheContext, IDatas datas, ILogger logger)
        {
            _cacheContext = cacheContext;
            _datas = datas;
            _logger = logger;
        }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(MemberCollection) == typeToConvert;
        }

        public override MemberCollection Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            MemberCollection memberCollection = new MemberCollection(_cacheContext.GetCache<ulong, Member>(), _logger);
            JsonDocument document = JsonDocument.ParseValue(ref reader);
            Span<Member> members = document.ToObject<Member[]>(options);
            for (int i = 0; i < members.Length; i++)
            {
                User user = members[i].User;
                _datas.Users.Caching(ref user);
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
