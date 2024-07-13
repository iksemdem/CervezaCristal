using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Spawn;
using Exiled.Events.EventArgs.Player;
using UnityEngine;
using AudioPlayer.API;
using System.IO;

namespace CervezaCristal.CustomItem
{
    public class Cerveza : Exiled.CustomItems.API.Features.CustomItem
    {
        public override uint Id { get; set; } = 99;

        public override string Name { get; set; } = "Cerveza Cristal";

        public override Vector3 Scale { get; set; } = new(1f, 1f, 1f);

        public override string Description { get; set; } = "Cerveza Cristal, plays sound when used";

        public override float Weight { get; set; } = 1f;

        public override ItemType Type { get; set; } = ItemType.SCP207;

        public override SpawnProperties SpawnProperties { get; set; }

        internal static List<Player> drankCerveza = new List<Player>();

        protected override void SubscribeEvents()
        {
            Exiled.Events.Handlers.Player.UsedItem += OnUsed;
            base.SubscribeEvents();
        }

        protected override void UnsubscribeEvents()
        {
            Exiled.Events.Handlers.Player.UsedItem -= OnUsed;
            base.UnsubscribeEvents();
        }

        protected override void ShowPickedUpMessage(Player player)
        {
        }

        protected override void ShowSelectedMessage(Player player)
        {
            player.ShowHint(Plugin.Instance.Config.HoldingMessage);
        }

        private void OnUsed(UsedItemEventArgs ev)
        {
            if (!Check(ev.Item))
                return;

            drankCerveza.Add(ev.Player);
            ev.Player.DisableEffect(EffectType.Scp207);
            ev.Player.MaxHealth = 150;
            ev.Player.Health = 150;
            var path = Path.Combine(Paths.Configs, "CervezaCristal");
            Log.Debug("Cerveza Cristal used");
            Log.Debug($"Path to the sound is: {path}/CervezaCristal.ogg");
            AudioController.SpawnDummy(99, "Dźwiękowiec", "orange", "BOT");
            AudioController.PlayAudioFromFile($"{path}/CervezaCristal.ogg", false, 100, VoiceChat.VoiceChatChannel.Intercom, false, false, true, 99);
        }
    }
}
