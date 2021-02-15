using FarDragi.DiscordCs.Json.Entities.ActivityModels;

namespace FarDragi.DiscordCs.Entities.ActivityModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#activity-object-activity-secrets
    /// </summary>
    public class ActivitySecrets
    {
        public string Join { get; set; }
        public string Spectate { get; set; }
        public string Match { get; set; }

        public static implicit operator ActivitySecrets(JsonActivitySecrets json)
        {
            if (json == null) return null;

            return new ActivitySecrets
            {
                Join = json.Join,
                Match = json.Match,
                Spectate = json.Spectate
            };
        }

        public static implicit operator JsonActivitySecrets(ActivitySecrets activitySecrets)
        {
            if (activitySecrets == null) return null;

            return new JsonActivitySecrets
            {
                Join = activitySecrets.Join,
                Match = activitySecrets.Match,
                Spectate = activitySecrets.Spectate
            };
        }
    }
}
