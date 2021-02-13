using FarDragi.DiscordCs.Json.Entities.UserModels;
using Newtonsoft.Json;
using System.Diagnostics;

namespace FarDragi.DiscordCs.Entities.UserModels
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/user#user-object-user-structure
    /// </summary>
    public class User
    {
        public ulong Id { get; set; }
        public string UserName { get; set; }
        public string Discriminator { get; set; }
        public string Nick { get; set; }
        public string Avatar { get; set; }
        public bool IsBot { get; set; }
        public bool IsSystem { get; set; }
        public bool IsMfaEnabled { get; set; }
        public string Locale { get; set; }
        public bool IsVerified { get; set; }
        public string Email { get; set; }
        public UserFlags Flags { get; set; }
        public UserPremiumTypes PremiumType { get; set; }
        public UserFlags PublicFlags { get; set; }

        public static implicit operator User(JsonUser json)
        {
            return new User
            {
                Avatar = json.Avatar,
                IsBot = json.IsBot,
                Discriminator = json.Discriminator,
                Email = json.Email,
                Flags = (UserFlags)json.Flags,
                Id = json.Id,
                Locale = json.Locale,
                IsMfaEnabled = json.IsMfaEnabled,
                PremiumType = (UserPremiumTypes)json.PremiumType,
                PublicFlags = (UserFlags)json.PublicFlags,
                IsSystem = json.IsSystem,
                UserName = json.UserName,
                IsVerified = json.IsVerified,
                Nick = $"{json.UserName}#{json.Discriminator}"
            };
        }
    }
}
