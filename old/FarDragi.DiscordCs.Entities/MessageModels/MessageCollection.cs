using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Rest.Api;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Entities.MessageModels
{
    public class MessageCollection : ICacheable<Message>
    {
        private readonly ICaching<Message> _cache;
        private readonly ulong _channelId;
        public ApiClient ApiClient { get; }

        public MessageCollection(ICaching<Message> messages, ApiClient apiClient, ulong channelId)
        {
            _cache = messages;
            ApiClient = apiClient;
            _channelId = channelId;
        }

        public Message this[in ulong id]
        {
            get
            {
                return _cache.Get(id);
            }
        }

        public async Task<Message> Add(string content)
        {
            return await Add(new Message
            {
                Content = content
            });
        }

        public async Task<Message> Add(Message message)
        {
            return await ApiClient.Send<Message, Message>(HttpMethod.Post, message, _channelId);
        }

        public Message Caching(ref Message data)
        {
            return _cache.Add(data.Id, data);
        }

        public Message Find(in ulong id)
        {
            return _cache.Get(id);
        }

        public IEnumerator<Message> GetEnumerator()
        {
            return _cache.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _cache.GetEnumerator();
        }
    }
}
