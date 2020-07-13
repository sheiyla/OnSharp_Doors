using Onsharp.Entities;
using Onsharp.Events;
using Onsharp.Plugins;

namespace OnSharp_Doors
{

    [PluginMeta("onsharp-doors", "Doors Plugin", "1.0", "Codeskull", IsDebug = true)]
    public class OnSharp_Doors : Plugin
    {

        public override void OnStart() 
        {
            Armed.OnArmed(Server);
            Bank.OnBank(Server);
            CockInBell.OnCockInBell(Server);
            Garage.OnGarage(Server);
            GasStation.OnGasStation(Server);
            Hospital.OnHospital(Server);
            House.OnHouse(Server);
            Motel.OnMotel(Server);
            OldTown.OnOldTown(Server);
            Other.OnOther(Server);
            Parking.OnParking(Server);
            Police.OnPolice(Server);
            Prison.OnPrison(Server);
            Pub.OnPub(Server);
            RadioTower.OnRadioTower(Server);
            Shooting.OnShooting(Server);
            Storage.OnStorage(Server);
            Store.OnStore(Server);
            WallStar.OnWallStar(Server);
        }

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