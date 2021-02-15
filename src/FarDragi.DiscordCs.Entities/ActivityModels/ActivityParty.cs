using FarDragi.DiscordCs.Json.Entities.ActivityModels;

namespace FarDragi.DiscordCs.Entities.ActivityModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#activity-object-activity-party
    /// </summary>
    public class ActivityParty
    {
        public string Id { get; set; }
        public int[] Size { get; set; }

        public static implicit operator ActivityParty(JsonActivityParty json)
        {
            if (json == null) return null;

            return new ActivityParty
            {
                Id = json.Id,
                Size = json.Size
            };
        }

        public static implicit operator JsonActivityParty(ActivityParty activityParty)
        {
            if (activityParty == null) return null;

            return new JsonActivityParty
            {
                Id = activityParty.Id,
                Size = activityParty.Size
            };
        }
    }
}
