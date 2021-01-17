using FarDragi.DiscordCs.Entities.IdentifyModels;
using FarDragi.DiscordCs.Gateway.Attributes;
using FarDragi.DiscordCs.Gateway.Interfaces;
using FarDragi.DiscordCs.Gateway.Socket;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace FarDragi.DiscordCs.Gateway
{
    public class GatewayClient
    {
        private readonly IGatewayEvents events;
        private readonly Identify config;
        private readonly WebSocketClient webSocket;
        private readonly Dictionary<string, Action<object, object>> eventsHandler;

        public int[] Shard { get; set; }

        public GatewayClient(IGatewayEvents gatewayEvents, Identify gatewayConfig)
        {
            Shard = gatewayConfig.Shard;
            events = gatewayEvents;
            config = gatewayConfig;
            eventsHandler = new Dictionary<string, Action<object, object>>();
            RegisterHandlers();
            webSocket = new WebSocketClient(this, config);
        }

        private void RegisterHandlers()
        {
            Type type = events.GetType();
            MethodInfo[] methodInfos = type.GetMethods();

            for (int i = 0; i < methodInfos.Length; i++)
            {
                GatewayEventAttribute eventNameAttribute = methodInfos[i].GetCustomAttribute<GatewayEventAttribute>();
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
