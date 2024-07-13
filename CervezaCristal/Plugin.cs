using System;
using System.IO;
using Exiled.API.Features;
using Exiled.CustomItems.API;

namespace CervezaCristal
{
    internal class Plugin : Plugin<Config>
    {
        private EventHandlers eventHandlers;

        public override string Author => "iksemdem";
        public override string Name => "CervezaCristal";
        public override string Prefix => "Cerveza_cristal";
        public override Version Version => new Version(1, 1, 1);
        public static Plugin Instance { get; private set; }

        public override void OnEnabled()
        {
            try
            {
                string path = Path.Combine(Paths.Configs, "CervezaCristal");

                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
            }
            catch (Exception e)
            {
                Log.Error($"Loading error: {e}");
            }

            Instance = this;
            eventHandlers = new EventHandlers();
            RegisterEvents();
            RegisterItems();

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Instance = null;
            UnRegisterEvents();
            UnRegisterItems();

            base.OnDisabled();
        }

        private void RegisterEvents()
        {
            Exiled.Events.Handlers.Player.Died += eventHandlers.OnDead;
        }

        private void UnRegisterEvents()
        {
            Exiled.Events.Handlers.Player.Died -= eventHandlers.OnDead;
        }

        private void RegisterItems()
        {
            Config.Cerveza.Register();
        }

        private void UnRegisterItems()
        {
            Config.Cerveza.Unregister();
        }
    }
}
