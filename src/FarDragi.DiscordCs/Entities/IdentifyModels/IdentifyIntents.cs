namespace FarDragi.DiscordCs.Entities.IdentifyModels
{
    public enum IdentifyIntent
    {
        None = 0,

        /// <summary>
        /// <see cref="Guilds"/><br/>
        /// <see cref="GuildBans"/><br/>
        /// <see cref="GuildEmojis"/><br/>
        /// <see cref="GuildIntegrations"/><br/>
        /// <see cref="GuildWebhooks"/><br/>
        /// <see cref="GuildInvites"/><br/>
        /// <see cref="GuildVoiceStates"/><br/>
        /// <see cref="GuildMessages"/><br/>
        /// <see cref="GuildMessageReactions"/><br/>
        /// <see cref="GuildMessageTyping"/><br/>
        /// <see cref="DirectMessages"/><br/>
        /// <see cref="DirectMessageReactions"/><br/>
        /// <see cref="DirectMessageTyping"/><br/>
        /// </summary>
        Default = 32509,

        /// <summary>
        /// <see cref="Guilds"/><br/>
        /// <see cref="GuildMembers"/><br/>
        /// <see cref="GuildBans"/><br/>
        /// <see cref="GuildEmojis"/><br/>
        /// <see cref="GuildIntegrations"/><br/>
        /// <see cref="GuildWebhooks"/><br/>
        /// <see cref="GuildInvites"/><br/>
        /// <see cref="GuildVoiceStates"/><br/>
        /// <see cref="GuildPresences"/><br/>
        /// <see cref="GuildMessages"/><br/>
        /// <see cref="GuildMessageReactions"/><br/>
        /// <see cref="GuildMessageTyping"/><br/>
        /// <see cref="DirectMessages"/><br/>
        /// <see cref="DirectMessageReactions"/><br/>
        /// <see cref="DirectMessageTyping"/><br/>
        /// </summary>
        All = 32767,

        /// <summary>
        /// GUILD_CREATE<br/>
        /// GUILD_UPDATE<br/>
        /// GUILD_DELETE<br/>
        /// GUILD_ROLE_CREATE<br/>
        /// GUILD_ROLE_UPDATE<br/>
        /// GUILD_ROLE_DELETE<br/>
        /// CHANNEL_CREATE<br/>
        /// CHANNEL_UPDATE<br/>
        /// CHANNEL_DELETE<br/>
        /// CHANNEL_PINS_UPDATE<br/>
        /// </summary>
        Guilds = 1,

        /// <summary>
        /// GUILD_MEMBER_ADD<br/>
        /// GUILD_MEMBER_UPDATE<br/>
        /// GUILD_MEMBER_REMOVE<br/>
        /// </summary>
        GuildMembers = 2,

        /// <summary>
        /// GUILD_BAN_ADD<br/>
        /// GUILD_BAN_REMOVE<br/>
        /// </summary>
        GuildBans = 4,

        /// <summary>
        /// GUILD_EMOJIS_UPDATE<br/>
        /// </summary>
        GuildEmojis = 8,

        /// <summary>
        /// GUILD_INTEGRATIONS_UPDATE<br/>
        /// </summary>
        GuildIntegrations = 16,

        /// <summary>
        /// WEBHOOKS_UPDATE<br/>
        /// </summary>
        GuildWebhooks = 32,

        /// <summary>
        /// INVITE_CREATE<br/>
        /// INVITE_DELETE<br/>
        /// </summary>
        GuildInvites = 64,

        /// <summary>
        /// VOICE_STATE_UPDATE<br/>
        /// </summary>
        GuildVoiceStates = 128,

        /// <summary>
        /// PRESENCE_UPDATE<br/>
        /// </summary>
        GuildPresences = 256,

        /// <summary>
        /// MESSAGE_CREATE<br/>
        /// MESSAGE_UPDATE<br/>
        /// MESSAGE_DELETE<br/>
        /// MESSAGE_DELETE_BULK<br/>
        /// </summary>
        GuildMessages = 512,

        /// <summary>
        /// MESSAGE_REACTION_ADD<br/>
        /// MESSAGE_REACTION_REMOVE<br/>
        /// MESSAGE_REACTION_REMOVE_ALL<br/>
        /// MESSAGE_REACTION_REMOVE_EMOJI<br/>
        /// </summary>
        GuildMessageReactions = 1024,

        /// <summary>
        /// TYPING_START<br/>
        /// </summary>
        GuildMessageTyping = 2048,

        /// <summary>
        /// MESSAGE_CREATE<br/>
        /// MESSAGE_UPDATE<br/>
        /// MESSAGE_DELETE<br/>
        /// CHANNEL_PINS_UPDATE<br/>
        /// </summary>
        DirectMessages = 4096,

        /// <summary>
        /// MESSAGE_REACTION_ADD<br/>
        /// MESSAGE_REACTION_REMOVE<br/>
        /// MESSAGE_REACTION_REMOVE_ALL<br/>
        /// MESSAGE_REACTION_REMOVE_EMOJI<br/>
        /// </summary>
        DirectMessageReactions = 8192,

        /// <summary>
        /// TYPING_START<br/>
        /// </summary>
        DirectMessageTyping = 16384
    }
}
