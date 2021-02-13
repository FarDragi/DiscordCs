using FarDragi.DiscordCs.Caching;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Entities.ChannelModels
{
    public class ChannelCollection : ICacheable<Channel>
    {
        private readonly ICaching<Channel> _channels;

        public ChannelCollection(ICaching<Channel> channels)
        {
            _channels = channels;
        }

        public Channel this[in ulong id]
        {
            get
            {
                return _channels.Get(id);
            }
        }

        public Channel Caching(ref Channel data)
        {
            return _channels.Add(data.Id, data);
        }

        public IEnumerator<Channel> GetEnumerator()
        {
            return _channels.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _channels.GetEnumerator();
        }
    }
}
