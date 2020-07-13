using Onsharp;
using Onsharp.World;

namespace OnSharp_Doors
{

	public class Parking : OnSharp_Doors
	{

		public static void OnParking(IServer Server)
		{

			// City Underground Parking
			Server.CreateDoor(76, new Vector(142797.000000, 184099.000000, 1346.000000), 0.0, true);
			Server.CreateDoor(76, new Vector(148201.000000, 184639.000000, 1017.000000), 180.0, true);
			Server.CreateDoor(76, new Vector(148312.000000, 182659.000000, 1348.000000), -90.0, true);

		}

	}

}