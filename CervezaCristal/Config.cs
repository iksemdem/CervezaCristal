using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Interfaces;
using CervezaCristal.CustomItem;

namespace CervezaCristal
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        [Description("Content shown while equipping Cerveza Cristal.")]
        public Exiled.API.Features.Hint HoldingMessage { get; set; } = new("You are holding a <b><color=yellow>Cerveza Cristal</color></b>!", 7);

        public static List<Cerveza> Cerveza { get; private set; } = new()
        {
            new Cerveza(),
        };

    }
}
