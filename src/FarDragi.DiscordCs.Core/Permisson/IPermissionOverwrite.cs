using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DiscordCs.Core.Permisson
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/channel#overwrite-object-overwrite-structure
    /// </summary>
    public interface IPermissionOverwrite
    {
        public ulong Id { get; set; }
        public int Type { get; set; }
        public ulong Allow { get; set; }
        public ulong Deny { get; set; }
    }
}
