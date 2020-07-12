using Onsharp.Events;
using Onsharp.World;

namespace OnSharp_Doors
{

	public class Bank : OnSharp_Doors
	{

		[ServerEvent(EventType.PackageStart)]
		public void OnBank()
		{

			// IWB Bank Branch
			Server.CreateDoor(17, new Vector(214254.000000, 190268.000000, 1209.000000), 180.0, true);
			Server.CreateDoor(17, new Vector(212558.000000, 190314.000000, 1211.000000), 90.0, true);
			Server.CreateDoor(63, new Vector(213264.000000, 191315.000000, 1211.000000), 0.0, true);
			Server.CreateDoor(63, new Vector(213264.000000, 191896.000000, 1211.000000), 0.0, true);
			Server.CreateDoor(63, new Vector(214722.000000, 190967.000000, 1211.000000), 180.0, true);
			Server.CreateDoor(63, new Vector(214722.000000, 191549.000000, 1211.000000), 180.0, true);
			Server.CreateDoor(63, new Vector(215228.000000, 192407.000000, 1211.000000), -90.0, true);
			Server.CreateDoor(64, new Vector(214090.000000, 192008.000000, 1211.000000), 180.0, true);
			Server.CreateDoor(65, new Vector(214176.000000, 192436.000000, 1242.000000), 180.0, true);
			Server.CreateDoor(30, new Vector(212689.000000, 193031.000000, 1214.000000), 0.0, true);

			// IWB Bank Underground
			Server.CreateDoor(73, new Vector(185069.000000, 203285.000000, 295.000000), -90.0, true); // safe
			Server.CreateDoor(74, new Vector(185034.000000, 201752.000000, 263.000000), -90.0, true); // safe 2
			Server.CreateDoor(75, new Vector(186334.000000, 203004.000000, 68.000000), -90.0, true);

			// Desert Town 2 Bank/Postal Office
			Server.CreateDoor(35, new Vector(43348.000000, 133507.000000, 1470.500000), 0.0, true);
			Server.CreateDoor(55, new Vector(43148.000000, 132201.000000, 1470.000000), 180.0, true);
			Server.CreateDoor(58, new Vector(43427.000000, 132744.000000, 1471.000000), 0.0, true);

		}

	}

}