using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entities.MessageModels;
using FarDragi.DiscordCs.Rest;
using FarDragi.DiscordCs.Rest.Api;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Entities.ChannelModels
{
    public class ChannelCollection : ICacheable<Channel>
    {
        private readonly ICaching<Channel> _cache;
        public ApiClient Api { get; }

        public ChannelCollection(ICaching<Channel> cache, RestClient restClient)
        {
            _cache = cache;
            Api = restClient.GetApiClient("/channels/{0}/messages");
        }

        public async Task<Message> AddMessage(string content)
        {
            return await Api.Send<Message, Message>(HttpMethod.Post, new Message
            {
                Content = content
            }, "764668379339816961");
        }

        public Channel this[in ulong id]
        {
            get
            {
                return _cache.Get(id);
            }
        }

        public Channel Caching(ref Channel data)
        {
            return _cache.Add(data.Id, data);
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
