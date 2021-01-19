using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Collections
{
    public class CollectionBase<TType>
    {
        private readonly Dictionary<string, TType> pairs;

        public CollectionBase()
        {
            pairs = new Dictionary<string, TType>();
        }

        public TType this[string id]
        {
            get
            {
                return pairs[id];
            }
            set
            {
                pairs[id] = value;
            }
        }
    }
}
