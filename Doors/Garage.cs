using Onsharp.Events;
using Onsharp.World;

namespace OnSharp_Doors
{

	public class Garage : OnSharp_Doors
	{

		[ServerEvent(EventType.PackageStart)]
		public void OnGarage()
		{

			// Town level garages
			Server.CreateDoor(41, new Vector(-174589.000000, -38487.000000, 1025.000000), -90.0, true);
			Server.CreateDoor(41, new Vector(-172828.000000, -41752.000000, 1025.000000), 0.0, true);
			Server.CreateDoor(41, new Vector(-177836.000000, -38578.000000, 1025.000000), 90.0, true);
			Server.CreateDoor(41, new Vector(-174588.000000, -45277.000000, 1025.000000), -90.0, true);
			Server.CreateDoor(41, new Vector(-172818.000000, -33414.000000, 1025.000000), 0.0, true);
			Server.CreateDoor(41, new Vector(-180508.000000, -55740.000000, 1025.000000), 0.0, true);
			Server.CreateDoor(41, new Vector(-185429.000000, -55740.000000, 1025.000000), 0.0, true);
			Server.CreateDoor(41, new Vector(-189619.000000, -55740.000000, 1025.000000), 0.0, true);
			Server.CreateDoor(41, new Vector(-193301.000000, -55363.000000, 1025.000000), 90.0, true);
			Server.CreateDoor(41, new Vector(-189483.000000, -59061.000000, 1025.000000), -180.0, true);
			Server.CreateDoor(41, new Vector(-189647.000000, -62736.000000, 1025.000000), 0.0, true);
			Server.CreateDoor(41, new Vector(-179389.000000, -62734.000000, 1025.000000), 0.0, true);
			Server.CreateDoor(41, new Vector(-176790.890625, -83896.843750, 1589.000000), -88.0, true);
			Server.CreateDoor(41, new Vector(-176838.281250, -82539.664063, 1589.000000), -88.0, true);
			Server.CreateDoor(42, new Vector(-172121.671875, -87257.554688, 1421.000000), -116.0, true);

		}

	}

}