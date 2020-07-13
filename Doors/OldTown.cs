using Onsharp;
using Onsharp.World;

namespace OnSharp_Doors
{

	public class OldTown : OnSharp_Doors
	{

		public static void OnOldTown(IServer Server)
		{

			// Old Town
			Server.CreateDoor(77, new Vector(-80742.218750, -160053.750000, 3222.000000), -5.0, true); // Saloon
			Server.CreateDoor(78, new Vector(-80831.648438, -161772.890625, 3223.000000), 175.0, true);
			Server.CreateDoor(78, new Vector(-80602.960938, -163605.046875, 3209.000000), -150.0, true);
			Server.CreateDoor(78, new Vector(-79427.625000, -166247.640625, 3215.000000), -40.0, true);
			Server.CreateDoor(78, new Vector(-78041.062500, -164739.656250, 3223.000000), -70.0, true);
			Server.CreateDoor(78, new Vector(-76387.984375, -164619.890625, 3304.000000), -80.0, true);
			Server.CreateDoor(78, new Vector(-74112.515625, -164532.296875, 3306.000000), -80.0, true);
			Server.CreateDoor(78, new Vector(-75924.000000, -162730.000000, 3290.000000), 90.0, true);
			Server.CreateDoor(78, new Vector(-78523.000000, -162156.000000, 3219.000000), 180.0, true);
			Server.CreateDoor(78, new Vector(-78891.000000, -159878.000000, 3212.000000), 0.0, true);
			Server.CreateDoor(78, new Vector(-78879.000000, -159657.000000, 3212.000000), 180.0, true);
			Server.CreateDoor(78, new Vector(-76492.867188, -159647.953125, 3332.648682), -90.0, true);

		}

	}

}