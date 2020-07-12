using Onsharp.Events;
using Onsharp.World;

namespace OnSharp_Doors
{

	public class RadioTower : OnSharp_Doors
	{

		[ServerEvent(EventType.PackageStart)]
		public void OnRadioTower()
		{

			// Desert House 1 near radio tower mountain
			Server.CreateDoor(20, new Vector(186641.968750, -41649.476563, 1417.000000), 175.0, true); // Door Entrance
			Server.CreateDoor(24, new Vector(186425.968750, -41678.332031, 1417.000000), 85.0, true); // Door Interior
			Server.CreateDoor(21, new Vector(185851.750000, -41129.601563, 1417.000000), -5.0, true); // Door Back Door

			// Desert House 2 near radio tower mountain
			Server.CreateDoor(20, new Vector(192122.000000, -45262.136719, 1436.000000), 290.0, true); // Door Entrance
			Server.CreateDoor(24, new Vector(192512.546875, -45539.789063, 1436.000000), 200.0, true); // Door Interior

		}

	}

}