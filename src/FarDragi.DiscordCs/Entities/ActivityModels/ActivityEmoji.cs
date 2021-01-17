using FarDragi.DiscordCs.Json.Entities.ActivityModels;

namespace FarDragi.DiscordCs.Entities.ActivityModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#activity-object-activity-emoji
    /// </summary>
    public class ActivityEmoji
    {
        public string Name { get; set; }
        public ulong? Id { get; set; }
        public bool Animated { get; set; }

        public static implicit operator JsonActivityEmoji(ActivityEmoji activityEmoji)
        {
            return new JsonActivityEmoji
            {
                Animated = activityEmoji.Animated,
                Id = activityEmoji.Id,
                Name = activityEmoji.Name
            };
        }
    }
}
