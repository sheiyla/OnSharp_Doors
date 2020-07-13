using Onsharp;
using Onsharp.World;

namespace OnSharp_Doors
{

	public class Hospital : OnSharp_Doors
	{

		public static void OnHospital(IServer Server)
		{

			// City Hospital Interior Part 1
			Server.CreateDoor(61, new Vector(215443.000000, 159292.000000, 2857.000000), 0.0, true);
			Server.CreateDoor(61, new Vector(215593.000000, 159058.000000, 2857.000000), 90.0, true);
			Server.CreateDoor(61, new Vector(215677.000000, 158642.000000, 2857.000000), 270.0, true);
			Server.CreateDoor(62, new Vector(216076.000000, 159042.000000, 2857.000000), 270.0, true);

			// City Hospital Interiort Part 2 Floor 2
			Server.CreateDoor(62, new Vector(212745.000000, 157043.000000, 2682.000000), -90.0, true);
			Server.CreateDoor(62, new Vector(212709.000000, 156259.000000, 2682.000000), 90.0, true);
			Server.CreateDoor(61, new Vector(212560.000000, 156494.000000, 2682.000000), 0.0, true);
			Server.CreateDoor(61, new Vector(213510.000000, 153860.000000, 2682.000000), 90.0, true);
			Server.CreateDoor(62, new Vector(212395.000000, 153453.000000, 2682.000000), -90.0, true);

			// City Hospital Interiort Part 2 Floor 1
			Server.CreateDoor(62, new Vector(212745.000000, 157043.000000, 2331.0), -90.0, true);
			Server.CreateDoor(62, new Vector(212709.000000, 156259.000000, 2331.0), 90.0, true);
			Server.CreateDoor(61, new Vector(212560.000000, 156494.000000, 2331.0), 0.0, true);
			Server.CreateDoor(61, new Vector(213510.000000, 153860.000000, 2331.0), 90.0, true);
			Server.CreateDoor(62, new Vector(212395.000000, 153453.000000, 2331.0), -90.0, true);

		}

	}

}