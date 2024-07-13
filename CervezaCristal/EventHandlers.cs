using CervezaCristal.CustomItem;
using Exiled.Events.EventArgs.Player;

namespace CervezaCristal
{
    internal class EventHandlers
    {
        internal void OnDead(DiedEventArgs ev)
        {
            if (Cerveza.drankCerveza.Contains(ev.Player))
            {
                Cerveza.drankCerveza.Remove(ev.Player);
            }
        }
    }
}
