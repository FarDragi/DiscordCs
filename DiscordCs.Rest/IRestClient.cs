using System.Net.Http;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Rest
{
    public interface IRestClient
    {
        public Task<TOutput> Send<TInput, TOutput>(HttpMethod method, TInput input, string url) where TInput : class where TOutput : class;
        public Task Send(HttpMethod method, string url);
    }
}
