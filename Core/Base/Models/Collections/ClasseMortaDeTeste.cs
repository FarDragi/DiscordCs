using FarDragi.DiscordCs.Core.Base.Models.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace FarDragi.DiscordCs.Core.Base.Models.Collections
{
    public class ClasseMortaDeTeste
    {
        public void Teste()
        {
            DiscordGuildList guilds = new DiscordGuildList(new Rest.Client.RestClient(new Rest.Models.Identify.IdentifyRest()));
            var result = from guild in guilds where guild.Id == 0 select guild;


            List<Base.DiscordGuild> enumerable = guilds.Append(new Base.DiscordGuild()).ToList();
        }
    }
}
