using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Rest
{
    public interface IRestContext
    {
        public IRestClient GetClient(string urlFormat);
        public void Init();
        public void Config(IRestConfig config);
    }
}
