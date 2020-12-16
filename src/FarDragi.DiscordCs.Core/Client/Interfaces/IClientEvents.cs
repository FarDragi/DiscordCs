using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Core.Client.Interfaces
{
    public interface IClientEvents
    {
        public delegate Task EventRaw(string data);

        public event EventRaw Raw;

        public void OnRaw(string data);
    }
}
