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

        public static implicit operator ActivityEmoji(JsonActivityEmoji json)
        {
            if (json == null) return null;

            return new ActivityEmoji
            {
                Animated = json.Animated,
                Id = json.Id,
                Name = json.Name
            };
        }

        public static implicit operator JsonActivityEmoji(ActivityEmoji activityEmoji)
        {
            if (activityEmoji == null) return null;

            return new JsonActivityEmoji
            {
                Animated = activityEmoji.Animated,
                Id = activityEmoji.Id,
                Name = activityEmoji.Name
            };
        }
    }
}
