namespace FarDragi.DiscordCs.Entities.MessageModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#message-object-message-types
    /// </summary>
    public enum MessageTypes
    {
        Default = 0,
        RecipientAdd = 1,
        RecipientRemove = 2,
        Call = 3,
        ChannelNameChange = 4,
        ChannelIconChange = 5,
        ChannelPinnedMessage = 6,
        GuildMemberJoin = 7,
        UserPremiumGuildSubscription = 8,
        UserPremiumGuildSubscriptionTier1 = 9,
        UserPremiumGuildSubscriptionTier2 = 10,
        UserPremiumGuildSubscriptionTier3 = 11,
        ChannelFollowAdd = 12,
        GuildDiscoveryDisqualified = 14,
        GuildDiscoveryRequalified = 15,
        Reply = 19,
        ApplicationCommand = 20
    }
}
