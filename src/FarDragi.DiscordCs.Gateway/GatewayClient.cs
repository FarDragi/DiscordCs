using FarDragi.DiscordCs.Gateway.Attributes;
using FarDragi.DiscordCs.Gateway.Interface;
using FarDragi.DiscordCs.Gateway.Socket;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace FarDragi.DiscordCs.Gateway
{
    public class GatewayClient
    {
        private readonly IGatewayEvents events;
        private readonly GatewayConfig config;
        private readonly WebSocketClient webSocket;
        private readonly Dictionary<string, Action<object, object>> eventsHandler;

        public GatewayClient(IGatewayEvents gatewayEvents, GatewayConfig gatewayConfig)
        {
            events = gatewayEvents;
            config = gatewayConfig;
            eventsHandler = new Dictionary<string, Action<object, object>>();
            RegisterHandlers();
            webSocket = new WebSocketClient(this, config.Identify);
        }

        private void RegisterHandlers()
        {
            Type type = events.GetType();
            MethodInfo[] methodInfos = type.GetMethods();

            for (int i = 0; i < methodInfos.Length; i++)
            {
                EventNameAttribute eventNameAttribute = methodInfos[i].GetCustomAttribute<EventNameAttribute>();
                if (eventNameAttribute != null)
                {
                    eventsHandler.Add(eventNameAttribute.Name, (Action<object, object>)methodInfos[i].CreateDelegate(typeof(Action<object, object>), events));
                }
            }
        }

        public void Open()
        {
            webSocket.Open();
        }

        public void OnEventReceived(string eventName, object json)
        {
            events.OnRaw(this, json);
            if (eventsHandler.TryGetValue(eventName, out Action<object, object> onAction))
            {
                onAction.Invoke(this, json);
            }
        }
    }
}
