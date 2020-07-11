using FarDragi.DragiCordApi.Core.Base.Models.Event;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarDragi.DragiCordApi.Core.Base.Models.EventsArgs
{
    public class ReadyEventArgs
    {
        public Ready Data { get; set; }

        public ReadyEventArgs(Ready ready)
        {
            Data = ready;
        }
    }
}
