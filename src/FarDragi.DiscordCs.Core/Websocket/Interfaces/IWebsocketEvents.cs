namespace FarDragi.DiscordCs.Core.Websocket.Interfaces
{
    public interface IWebsocketEvents
    {
        public void OnDataReceived(string json);
        public void OnOpened();
    }
}
