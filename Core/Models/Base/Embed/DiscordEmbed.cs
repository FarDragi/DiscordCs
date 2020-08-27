using FarDragi.DiscordCs.Core.Models.Collections;
using System;

namespace FarDragi.DiscordCs.Core.Models.Base.Embed
{
    public class DiscordEmbed
    {
        public string Title { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public DateTime Timestamp { get; set; }
        public uint Color { get; set; }
        public DiscordFooter Footer { get; set; }
        public DiscordImage Image { get; set; }
        public DiscordThumbnail Thumbnail { get; set; }
        public DiscordVideo Video { get; set; }
        public DiscordProvider Provider { get; set; }
        public DiscordAuthor Author { get; set; }
        public DiscordFieldList Fields { get; set; }
    }
}
