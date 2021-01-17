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

        public static implicit operator JsonActivityParty(ActivityParty activityParty)
        {
            return new JsonActivityParty
            {
                Id = activityParty.Id,
                Size = activityParty.Size
            };
        }
    }
}
