using Onsharp;
using Onsharp.World;

namespace OnSharp_Doors
{

	public class WallStar : OnSharp_Doors
	{

		public static void OnWallStar(IServer Server)
		{

			// WallStar
			Server.CreateDoor(31, new Vector(136690.000000, 192001.000000, 1194.000000), 90.0, true);
			Server.CreateDoor(79, new Vector(133346.000000, 192545.000000, 1196.000000), -90.0, true);
			Server.CreateDoor(80, new Vector(133345.000000, 192355.000000, 1194.000000), -90.0, true);

			Server.CreateDoor(79, new Vector(132281.000000, 192545.000000, 1193.000000), -90.0, true);
			Server.CreateDoor(80, new Vector(132280.000000, 192355.000000, 1193.000000), -90.0, true);
			Server.CreateDoor(81, new Vector(132478.000000, 191426.000000, 1193.000000), -90.0, true);
			Server.CreateDoor(81, new Vector(132916.000000, 193233.000000, 1194.000000), 0.0, true);
			Server.CreateDoor(81, new Vector(133345.000000, 190506.000000, 1193.000000), -90.0, true);
			Server.CreateDoor(81, new Vector(133295.000000, 190573.000000, 1194.000000), 180.0, true);
			Server.CreateDoor(81, new Vector(132438.000000, 190573.000000, 1194.000000), 180.0, true);

		}

	}

}