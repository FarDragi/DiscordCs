using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entity.Collections;
using FarDragi.DiscordCs.Entity.Interfaces;
using FarDragi.DiscordCs.Entity.Models.UserModels;
using FarDragi.DiscordCs.Logging;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Converters
{
    public class UserCollectionConverter : JsonConverter<UserCollection>
    {
        private readonly ICacheContext _cacheContext;
        private readonly IDatas _datas;
        private readonly ILogger _logger;

        public UserCollectionConverter(ICacheContext cacheContext, IDatas datas, ILogger logger)
        {
            _cacheContext = cacheContext;
            _datas = datas;
            _logger = logger;
        }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(UserCollection) == typeToConvert;
        }

        public override UserCollection Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            UserCollection usersCollection = new UserCollection(_cacheContext.GetCache<ulong, User>(), _logger);
            JsonDocument document = JsonDocument.ParseValue(ref reader);
            Span<User> users = document.ToObject<User[]>(options);

            for (int i = 0; i < users.Length; i++)
            {
                usersCollection.Caching(ref users[i]);
                _datas.Users.Caching(ref users[i]);
            }

            return usersCollection;
        }

        public override void Write(Utf8JsonWriter writer, UserCollection value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, (IEnumerable<User>)value);
        }
    }
}
