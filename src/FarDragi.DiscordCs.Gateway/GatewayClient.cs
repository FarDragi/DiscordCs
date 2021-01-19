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
        private readonly IGatewayEvents events;
        private readonly JsonIdentify identify;
        private readonly WebSocketClient webSocket;
        private readonly Dictionary<string, GatewayEvent> eventsHandler;

        public int[] Shard { get; set; }
        public int SessionId { get; set; }

        public GatewayClient(IGatewayEvents gatewayEvents, JsonIdentify gatewayIdentify)
        {
            Shard = gatewayIdentify.Shard;
            events = gatewayEvents;
            identify = gatewayIdentify;
            eventsHandler = new Dictionary<string, GatewayEvent>();
            RegisterHandlers();
            webSocket = new WebSocketClient(this, identify);
        }

        private void RegisterHandlers()
        {
            Type type = events.GetType();
            MethodInfo[] methodInfos = type.GetMethods();

            Parallel.For(0, methodInfos.Length, i =>
            {
                GatewayEventAttribute eventNameAttribute = methodInfos[i].GetCustomAttribute<GatewayEventAttribute>();
                if (eventNameAttribute != null)
                {
                    GatewayEvent gatewayEvent = new GatewayEvent
                    {
                        TypeConvert = eventNameAttribute.Type,
                        Delegate = (GatewayDelegate)methodInfos[i].CreateDelegate(typeof(GatewayDelegate), events)
                    };

                    eventsHandler.Add(eventNameAttribute.Name, gatewayEvent);
                }
            });
        }

        public void Open()
        {
            webSocket.Open();
        }

        public void OnEventReceived(string eventName, JObject data, string json)
        {
            events.OnRaw(this, json);
            if (eventsHandler.TryGetValue(eventName, out GatewayEvent gatewayEvent))
            {
                gatewayEvent.Delegate.Invoke(this, data.ToObject(gatewayEvent.TypeConvert));
            }
        }
    }
}
