using System.Net.Http;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Rest
{
    public interface IRestClient
    {
        public Task<TOutput> Send<TInput, TOutput>(HttpMethod method, TInput input, params string[] urlParams) where TInput : class where TOutput : class;
    }
}
