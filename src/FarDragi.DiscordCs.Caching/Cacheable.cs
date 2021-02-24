namespace FarDragi.DiscordCs.Caching
{
    public abstract class Cacheable<TType>
    {
        protected readonly ICaching<TType> _cache;

        public Cacheable(ICaching<TType> cache)
        {
            _cache = cache;
        }
    }
}
