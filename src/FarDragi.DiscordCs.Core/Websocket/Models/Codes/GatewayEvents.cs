using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Core.Websocket.Models.Codes
{
    /*
     * 
        ,
        ,
        ,
        ,
        ,
        GUILD_UPDATE,
        GUILD_DELETE,
        GUILD_BANADD,
        GUILD_BAN_REMOVE,
        GUILD_EMOJIS_UPDATE,
        GUILD_INTEGRATIONS_UPDATE,
        GUILD_MEMBER_ADD,
        GUILD_MEMBER_REMOVE,
        GUILD_MEMBER_UPDATE,
        GUILD_MEMBERS_CHUNK,
        GUILD_ROLE_CREATE,
        GUILD_ROLE_UPDATE,
        GUILD_ROLE_DELETE,
        INVITE_CREATE,
        INVITE_DELETE,
        MESSAGE_CREATE,
        MESSAGE_UPDATE,
        MESSAGE_DELETE,
        MESSAGE_DELETE_BULK,
        MESSAGE_REACTION_ADD,
        MESSAGE_REACTION_REMOVE,
        MESSAGE_REACTION_REMOVE_ALL,
        MESSAGE_REACTION_REMOVE_EMOJI,
        PRESENCE_UPDATE,
        TYPING_START,
        USER_UPDATE,
        VOICE_STATE_UPDATE,
        VOICE_SERVER_UPDATE,
        WEBHOOKS_UPDATE
     */
    public enum GatewayEvents
    {
        [EnumMember(Value = "HELLO")]
        Hello,

        [EnumMember(Value = "READY")]
        Ready,

        [EnumMember(Value = "RESUMED")]
        Resumed,

        [EnumMember(Value = "RECONNECT")]
        Reconnect,

        [EnumMember(Value = "INVALID_SESSION")]
        InvalidSession,

        [EnumMember(Value = "CHANNEL_CREATE")]
        ChannelCreate,

        [EnumMember(Value = "CHANNEL_UPDATE")]
        ChannelUpdate,

        [EnumMember(Value = "CHANNEL_DELETE")]
        CHannelDelete,

        [EnumMember(Value = "CHANNEL_PINS_UPDATE")]
        ChannelPinsUpdate,

        [EnumMember(Value = "GUILD_CREATE")]
        GuildCreate
    }
}
