using FarDragi.DiscordCs.Caching;
using FarDragi.DiscordCs.Entity.Models.EmbedModels;
using FarDragi.DiscordCs.Entity.Models.MessageModels;
using FarDragi.DiscordCs.Logging;
using FarDragi.DiscordCs.Rest;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Entity.Collections
{
    public class MessageCollection : ICacheable<ulong, Message>
    {
        private readonly ICache<ulong, Message> _cache;
        private readonly IRestClient _rest;

        public MessageCollection(ICache<ulong, Message> cache, IRestContext rest, JsonSerializerOptions serializerOptions, ILogger logger, ulong channelId)
        {
            _cache = cache;
            _rest = rest.GetClient($"MessagesChannel{channelId}", $"/channels/{channelId}/messages", serializerOptions, logger);
        }

        public Message Caching(ref Message entity, bool update = false)
        {
            if (update)
            {
                _cache.Set(entity.Id, ref entity);
                return entity;
            }
            else
            {
                _cache.Add(entity.Id, ref entity);
                return entity;
            }
        }

        public Message Find(ulong key)
        {
            return _cache.Get(key);
        }

        public IEnumerator<Message> GetEnumerator()
        {
            return _cache.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _cache.GetEnumerator();
        }

        /// <summary>
        /// Send message in channel
        /// </summary>
        /// <param name="content">message</param>
        /// <param name="embed">embed</param>
        /// <param name="isTts">tts enabled</param>
        /// <returns></returns>
        public async Task<Message> Add(string content, Embed embed = null, bool isTts = false)
        {
            return await Add(new Message
            {
                Content = content,
                Embed = embed,
                IsTts = isTts
            });
        }

        public async Task<Message> Add(Embed embed)
        {
            return await Add(new Message
            {
                Embed = embed
            });
        }

        private async Task<Message> Add(Message message)
        {
            message = await _rest.Send<Message, Message>(HttpMethod.Post, message, "");
            Caching(ref message);
            return message;
        }

        public async Task Delete(Message message)
        {
            await Delete(message.Id);
        }

        public async Task Delete(ulong id)
        {
            await _rest.Send(HttpMethod.Delete, $"/{id}");
        }
    }
}
