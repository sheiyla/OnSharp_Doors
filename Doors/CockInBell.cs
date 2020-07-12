using Onsharp.Events;
using Onsharp.World;

namespace OnSharp_Doors
{

	public class CockInBell : OnSharp_Doors
	{

		[ServerEvent(EventType.PackageStart)]
		public void OnCockInBell()
		{

			// COCK IN BELL
			Server.CreateDoor(68, new Vector(194613.000000, 175873.000000, 1228.000000), -90.0, true);
			Server.CreateDoor(68, new Vector(194613.000000, 175618.000000, 1228.000000), 90.0, true);
			Server.CreateDoor(68, new Vector(194613.000000, 175618.000000, 1228.000000), 90.0, true);
			Server.CreateDoor(68, new Vector(192843.000000, 174858.000000, 1228.000000), 0.0, true);
			Server.CreateDoor(68, new Vector(192971.000000, 176537.000000, 1228.000000), 180.0, true);
			Server.CreateDoor(69, new Vector(191226.000000, 175630.000000, 1226.000000), 0.0, true);
			Server.CreateDoor(69, new Vector(191569.000000, 174860.000000, 1226.000000), 180.0, true);
			Server.CreateDoor(70, new Vector(192453.000000, 175294.000000, 1226.000000), -90.0, true);
			Server.CreateDoor(71, new Vector(192453.000000, 175178.000000, 1226.000000), -90.0, true);
			Server.CreateDoor(72, new Vector(191175.000000, 194157.000000, 9240.000000), 0.0, true);
			Server.CreateDoor(72, new Vector(191176.000000, 192128.000000, 9239.000000), 0.0, true);
			Server.CreateDoor(72, new Vector(191751.000000, 193515.000000, 9239.000000), -90.0, true);

		}

	}

}