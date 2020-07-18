using FarDragi.DiscordCs.Core.Gateway.Client;
using FarDragi.DiscordCs.Core.Gateway.Codes;
using FarDragi.DiscordCs.Core.Gateway.Models.Events;
using FarDragi.DiscordCs.Core.Gateway.Models.EventsArgs;
using FarDragi.DiscordCs.Core.Gateway.Models.Payloads;
using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Core.Gateway.Workers
{
    internal sealed class DispatchWorker
    {
        internal GatewayClient _client;

        public DispatchWorker(GatewayClient client)
        {
            _client = client;
        }

        internal async Task Worker(JObject json)
        {
            await Task.Yield();

            string name = json["t"].ToString();

            GatewayEvent events = (GatewayEvent)Enum.Parse(typeof(GatewayEvent), name);

            //Console.WriteLine(new CultureInfo("pt-BR").TextInfo.ToTitleCase(name.ToLower().Replace('_', ' ')).Replace(" ", ""));

            switch (events)
            {
                case GatewayEvent.HELLO:
                    break;
                case GatewayEvent.READY:
                    PayloadRecived<EventReady> ready = json.ToObject<PayloadRecived<EventReady>>();
                    _client.OnEventReady(new GatewayEventReadyArgs(ready));
                    break;
                case GatewayEvent.RESUMED:
                    break;
                case GatewayEvent.RECONNECT:
                    break;
                case GatewayEvent.INVALID_SESSION:
                    break;
                case GatewayEvent.CHANNEL_CREATE:
                    break;
                case GatewayEvent.CHANNEL_UPDATE:
                    break;
                case GatewayEvent.CHANNEL_DELETE:
                    break;
                case GatewayEvent.CHANNEL_PINS_UPDATE:
                    break;
                case GatewayEvent.GUILD_CREATE:
                    PayloadRecived<EventGuildCreate> guildCreate = json.ToObject<PayloadRecived<EventGuildCreate>>();
                    _client.OnEventGuildCreate(new GatewayEventGuildCreateArgs(guildCreate));
                    break;
                case GatewayEvent.GUILD_UPDATE:
                    break;
                case GatewayEvent.GUILD_DELETE:
                    break;
                case GatewayEvent.GUILD_BANADD:
                    break;
                case GatewayEvent.GUILD_BAN_REMOVE:
                    break;
                case GatewayEvent.GUILD_EMOJIS_UPDATE:
                    break;
                case GatewayEvent.GUILD_INTEGRATIONS_UPDATE:
                    break;
                case GatewayEvent.GUILD_MEMBER_ADD:
                    break;
                case GatewayEvent.GUILD_MEMBER_REMOVE:
                    break;
                case GatewayEvent.GUILD_MEMBER_UPDATE:
                    break;
                case GatewayEvent.GUILD_MEMBERS_CHUNK:
                    break;
                case GatewayEvent.GUILD_ROLE_CREATE:
                    break;
                case GatewayEvent.GUILD_ROLE_UPDATE:
                    break;
                case GatewayEvent.GUILD_ROLE_DELETE:
                    break;
                case GatewayEvent.INVITE_CREATE:
                    break;
                case GatewayEvent.INVITE_DELETE:
                    break;
                case GatewayEvent.MESSAGE_CREATE:
                    PayloadRecived<EventMessageCreate> messageCreate = json.ToObject<PayloadRecived<EventMessageCreate>>();
                    _client.OnEventMessageCreate(new GatewayEventMessageCreateArgs(messageCreate));
                    break;
                case GatewayEvent.MESSAGE_UPDATE:
                    break;
                case GatewayEvent.MESSAGE_DELETE:
                    break;
                case GatewayEvent.MESSAGE_DELETE_BULK:
                    break;
                case GatewayEvent.MESSAGE_REACTION_ADD:
                    break;
                case GatewayEvent.MESSAGE_REACTION_REMOVE:
                    break;
                case GatewayEvent.MESSAGE_REACTION_REMOVE_ALL:
                    break;
                case GatewayEvent.MESSAGE_REACTION_REMOVE_EMOJI:
                    break;
                case GatewayEvent.PRESENCE_UPDATE:
                    break;
                case GatewayEvent.TYPING_START:
                    break;
                case GatewayEvent.USER_UPDATE:
                    break;
                case GatewayEvent.VOICE_STATE_UPDATE:
                    break;
                case GatewayEvent.VOICE_SERVER_UPDATE:
                    break;
                case GatewayEvent.WEBHOOKS_UPDATE:
                    break;
                default:
                    break;
            }
        }
    }
}
