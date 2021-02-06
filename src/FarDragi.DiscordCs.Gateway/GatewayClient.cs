using FarDragi.DiscordCs.Gateway.Attributes;
using FarDragi.DiscordCs.Gateway.Interfaces;
using FarDragi.DiscordCs.Gateway.Socket;
using FarDragi.DiscordCs.Json.Entities.IdentifyModels;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Gateway
{
    public class GatewayClient
    {
        private readonly IGatewayEvents _events;
        private readonly JsonIdentify _identify;
        private readonly WebSocketClient _webSocket;
        private readonly Dictionary<string, GatewayEvent> _eventsHandler;

        public int[] Shard { get; set; }
        public string SessionId { get; set; }

        public GatewayClient(IGatewayEvents events, JsonIdentify identify)
        {
            Shard = identify.Shard;
            _events = events;
            _identify = identify;
            _eventsHandler = new Dictionary<string, GatewayEvent>();
            RegisterHandlers();
            _webSocket = new WebSocketClient(this, _identify);
        }

        private void RegisterHandlers()
        {
            Type type = _events.GetType();
            MethodInfo[] methodInfos = type.GetMethods();

            for (int i = 0; i < methodInfos.Length; i++)
            {
                GatewayEventAttribute eventNameAttribute = methodInfos[i].GetCustomAttribute<GatewayEventAttribute>();
                if (eventNameAttribute != null)
                {
                    GatewayEvent gatewayEvent = new GatewayEvent
                    {
                        TypeConvert = eventNameAttribute.Type,
                        Delegate = (GatewayDelegate)methodInfos[i].CreateDelegate(typeof(GatewayDelegate), _events)
                    };

                    _eventsHandler.Add(eventNameAttribute.Name, gatewayEvent);
                }
            }
        }

        public async Task<bool> Open()
        {
            return await _webSocket.Open();
        }

        public void OnEventReceived(string eventName, JObject data, string json)
        {
            if (_eventsHandler.TryGetValue(eventName, out GatewayEvent gatewayEvent))
            {
                gatewayEvent.Delegate.Invoke(this, data.ToObject(gatewayEvent.TypeConvert));
            }
            _events.OnRawAsync(this, json);
        }
    }
}
