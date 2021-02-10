using FarDragi.DiscordCs.Entities.ActivityModels;
using FarDragi.DiscordCs.Json.Entities.ActivityModels;
using FarDragi.DiscordCs.Json.Entities.PresenceModels;

namespace FarDragi.DiscordCs.Entities.PresenceModels
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/gateway#update-status-gateway-status-update-structure
    /// </summary>
    public class PresenceStatusUpdate
    {
        public int? Since { get; set; }
        public Activity[] Activities { get; set; }
        public string Status { get; set; }
        public bool Afk { get; set; }

        public static implicit operator JsonPresenceStatusUpdate(PresenceStatusUpdate presenceStatusUpdate)
        {
            var json = new JsonPresenceStatusUpdate
            {
                Afk = presenceStatusUpdate.Afk,
                Since = presenceStatusUpdate.Since,
                Status = presenceStatusUpdate.Status
            };

            if (presenceStatusUpdate.Activities != null)
            {
                json.Activities = new JsonActivity[presenceStatusUpdate.Activities.Length];

                for (int i = 0; i < presenceStatusUpdate.Activities.Length; i++)
                {
                    json.Activities[i] = presenceStatusUpdate.Activities[i];
                }
            };

            return json;
        }
    }
}
