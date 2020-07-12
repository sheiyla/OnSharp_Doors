using Onsharp.Events;
using Onsharp.World;

namespace OnSharp_Doors
{

	public class Motel : OnSharp_Doors
	{

		[ServerEvent(EventType.PackageStart)]
		public void OnMotel()
		{

			// Desert Town 2 motel
			Server.CreateDoor(55, new Vector(48556.000000, 138325.000000, 1474.000000), 180.0, true);
			Server.CreateDoor(55, new Vector(47757.000000, 138325.000000, 1474.000000), 180.0, true);
			Server.CreateDoor(55, new Vector(46957.000000, 138325.000000, 1474.000000), 180.0, true);
			Server.CreateDoor(55, new Vector(46155.000000, 138325.000000, 1474.000000), 180.0, true);
			Server.CreateDoor(35, new Vector(45649.000000, 136965.000000, 1476.000000), -90.0, true);

			// Desert Town Motel
			Server.CreateDoor(50, new Vector(-24040.953125, -5436.221680, 1975.000000), 20.0, true);
			Server.CreateDoor(50, new Vector(-23760.482422, -6206.764160, 1975.000000), 20.0, true);
			Server.CreateDoor(50, new Vector(-23698.902344, -6375.904297, 1975.000000), 20.0, true);
			Server.CreateDoor(50, new Vector(-23418.433594, -7146.447266, 1975.000000), 20.0, true);
			Server.CreateDoor(50, new Vector(-23356.876953, -7315.593262, 1975.000000), 20.0, true);
			Server.CreateDoor(50, new Vector(-23076.404297, -8086.135254, 1975.000000), 20.0, true);
			Server.CreateDoor(50, new Vector(-23014.845703, -8255.282227, 1975.000000), 20.0, true);
			Server.CreateDoor(50, new Vector(-22734.367188, -9025.820313, 1975.000000), 20.0, true);
			Server.CreateDoor(50, new Vector(-24040.953125, -5436.221680, 2245.000000), 20.0, true);
			Server.CreateDoor(50, new Vector(-23760.482422, -6206.764160, 2245.000000), 20.0, true);
			Server.CreateDoor(50, new Vector(-23698.902344, -6375.904297, 2245.000000), 20.0, true);
			Server.CreateDoor(50, new Vector(-23418.433594, -7146.447266, 2245.000000), 20.0, true);
			Server.CreateDoor(50, new Vector(-23356.876953, -7315.593262, 2245.000000), 20.0, true);
			Server.CreateDoor(50, new Vector(-23076.404297, -8086.135254, 2245.000000), 20.0, true);
			Server.CreateDoor(50, new Vector(-23014.845703, -8255.282227, 2245.000000), 20.0, true);
			Server.CreateDoor(50, new Vector(-22734.367188, -9025.820313, 2245.000000), 20.0, true);
			Server.CreateDoor(50, new Vector(-25311.316406, -5982.586914, 1975.000000), 200.0, true);
			Server.CreateDoor(50, new Vector(-25030.845703, -6753.130371, 1975.000000), 200.0, true);
			Server.CreateDoor(50, new Vector(-24969.281250, -6922.274414, 1975.000000), 200.0, true);
			Server.CreateDoor(50, new Vector(-24688.818359, -7692.820801, 1975.000000), 200.0, true);
			Server.CreateDoor(50, new Vector(-24627.255859, -7861.965820, 1975.000000), 200.0, true);
			Server.CreateDoor(50, new Vector(-24346.783203, -8632.505859, 1975.000000), 200.0, true);
			Server.CreateDoor(50, new Vector(-24285.216797, -8801.649414, 1975.000000), 200.0, true);
			Server.CreateDoor(50, new Vector(-24004.757813, -9572.191406, 1975.000000), 200.0, true);
			Server.CreateDoor(50, new Vector(-25311.316406, -5982.586914, 2245.000000), 200.0, true);
			Server.CreateDoor(50, new Vector(-25030.845703, -6753.130371, 2245.000000), 200.0, true);
			Server.CreateDoor(50, new Vector(-24969.281250, -6922.274414, 2245.000000), 200.0, true);
			Server.CreateDoor(50, new Vector(-24688.818359, -7692.820801, 2245.000000), 200.0, true);
			Server.CreateDoor(50, new Vector(-24346.783203, -8632.505859, 2245.000000), 200.0, true);
			Server.CreateDoor(50, new Vector(-24285.216797, -8801.649414, 2245.000000), 200.0, true);
			Server.CreateDoor(50, new Vector(-24004.757813, -9572.191406, 2245.000000), 200.0, true);

		}

	}

}