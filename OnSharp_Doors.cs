using Onsharp.Entities;
using Onsharp.Events;
using Onsharp.Plugins;

namespace OnSharp_Doors
{

    [PluginMeta("onsharp-doors", "Doors Plugin", "1.0", "Codeskull", IsDebug = true)]
    public class OnSharp_Doors : Plugin
    {

        public override void OnStart() { }
        public override void OnStop() { }

        [ServerEvent(EventType.PackageStop)]
        public void OnPackageStop()
        {
            foreach (var door in Server.Doors)
                door.Destroy();
        }

        [ServerEvent(EventType.PlayerInteractDoor)]
        public void OnPlayerInteractDoor(Player player, Door door, bool isBeingOpened)
        {
            if (player.IsValid)
                if (!isBeingOpened) door.IsOpen = false;
                if (isBeingOpened) door.IsOpen = true;
        }

    }

}