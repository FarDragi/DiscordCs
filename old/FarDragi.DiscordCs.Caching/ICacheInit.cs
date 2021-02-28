using FarDragi.DiscordCs.Rest;

namespace FarDragi.DiscordCs.Caching
{
    public interface ICacheInit
    {
        public void InitCaching(ICacheConfig config, RestClient rest);
    }
}
