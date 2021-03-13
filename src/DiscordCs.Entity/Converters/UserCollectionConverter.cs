using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entity.Collections;
using FarDragi.DiscordCs.Entity.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FarDragi.DiscordCs.Entity.Converters
{
    public class UserCollectionConverter : JsonConverter<UserCollection>
    {
        private readonly ICacheContext _cacheContext;

        public UserCollectionConverter(ICacheContext cacheContext)
        {
            _cacheContext = cacheContext;
        }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(UserCollection).IsAssignableFrom(typeToConvert);
        }

        public override UserCollection Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            UserCollection usersCollection = new UserCollection(_cacheContext.GetCache<ulong, User>());
            User[] users = JsonSerializer.Deserialize<User[]>(reader.ValueSpan, options);

            for (int i = 0; i < users.Length; i++)
            {
                usersCollection.Caching(ref users[i]);
            }

            return usersCollection;
        }

        public override void Write(Utf8JsonWriter writer, UserCollection value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, (IEnumerable<User>)value);
        }
    }
}
