using System.Text.Json;

namespace FarDragi.DiscordCs.Rest
{
    public interface IRestContext
    {
        public IRestClient GetClient(string urlFormat, JsonSerializerOptions serializerOptions);
        public void Init();
        public void Config(IRestConfig config);
    }
}
