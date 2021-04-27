using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entity.Models.ChannelModels;
using FarDragi.DiscordCs.Logging;
using FarDragi.DiscordCs.Rest;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Entity.Collections
{
    public class ChannelCollection : ICacheable<ulong, Channel>
    {
        private readonly ICache<ulong, Channel> _cache;
        private readonly ILogger _logger;
        private readonly IRestClient _rest;

        public ChannelCollection(ICache<ulong, Channel> cache, IRestContext rest, JsonSerializerOptions serializerOptions, ILogger logger)
        {
            _cache = cache;
            _logger = logger;
            _rest = rest.GetClient("Channels", "/channels", serializerOptions, logger);
        }

        public Channel Caching(ref Channel entity, bool update = false)
        {
            _cache.Add(entity.Id, ref entity);
            return entity;
        }

        public async Task<Channel> Find(ulong key)
        {
            if (_cache.TryGet(key, out Channel channel))
            {
                return channel;
            }
            else
            {
                channel = await _rest.Send<Channel, Channel>(HttpMethod.Get, null, $"/{key}");
                Caching(ref channel);
                return channel;
            }
        }

        public IEnumerator<Channel> GetEnumerator()
        {
            return _cache.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _cache.GetEnumerator();
        }
    }
}
