using Onsharp.Events;
using Onsharp.World;

namespace OnSharp_Doors
{

	public class GasStation : OnSharp_Doors
	{

		[ServerEvent(EventType.PackageStart)]
		public void OnGasStation()
		{

			// City Gas Station
			Server.CreateDoor(32, new Vector(170431.000000, 204098.000000, 1313.000000), 0.0, true);
			Server.CreateDoor(36, new Vector(172326.000000, 202825.000000, 1316.000000), 0.0, true);
			Server.CreateDoor(47, new Vector(171750.000000, 203375.000000, 1315.000000), -90.0, true);

			// Desert Town 2 Gas Station
			Server.CreateDoor(17, new Vector(42812.000000, 137768.000000, 1479.000000), 180.0, true);
			Server.CreateDoor(25, new Vector(42803.000000, 138658.000000, 1484.000000), 0.0, true);
			Server.CreateDoor(59, new Vector(43811.000000, 138730.000000, 1484.000000), 0.0, true);
			Server.CreateDoor(37, new Vector(22581.000000, 137170.000000, 1459.000000), 180.0, true);
			Server.CreateDoor(47, new Vector(21980.000000, 136744.000000, 1460.000000), 0.0, true);

			// Oil refinery barriers
			Server.CreateDoor(6, new Vector(886.000000, 101391.000000, 1393.000000), -90.0, true);
			Server.CreateDoor(6, new Vector(886.000793, 102216.000000, 1393.000000), 90.0, true);

			// Desert Town Gas Station
			Server.CreateDoor(45, new Vector(-16291.268555, -1244.944214, 1969.000000), -70.0, true);
			Server.CreateDoor(46, new Vector(-15729.653320, -3201.937012, 1969.000000), 20.0, true);
			Server.CreateDoor(47, new Vector(-15637.296875, -3039.985596, 1968.000000), 110.0, true);
			Server.CreateDoor(47, new Vector(-14908.302734, -2773.298584, 1968.000000), -70.0, true);
			Server.CreateDoor(48, new Vector(-15423.785156, -1034.844238, 1969.000000), 20.0, true);
			Server.CreateDoor(49, new Vector(-16006.000977, -2465.996826, 1970.000000), 110.0, true);

			Server.CreateDoor(17, new Vector(128469.000000, 78057.000000, 1474.000000), 90.0, true); // Desert Gas Station Entrance Physics Door
			Server.CreateDoor(25, new Vector(128690.000000, 78965.000000, 1480.000000), 90.0, true); // Desert Gas Station Restroom
			Server.CreateDoor(3, new Vector(129315.000000, 79120.000000, 1478.000000), 0.0, true); // Desert Gas Station Back Door
			Server.CreateDoor(30, new Vector(129401.968750, 75810.203125, 1473.000000), 182.0, true); // Desert Gas Station Gas Tanks

		}

	}

}