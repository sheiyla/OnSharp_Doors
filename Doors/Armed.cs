using Onsharp;
using Onsharp.World;

namespace OnSharp_Doors
{
	
	public class Armed
	{

		public static void OnArmed(IServer Server)
		{

			// City Armed & Dangerous
			Server.CreateDoor(66, new Vector(206223.000000, 192734.000000, 1260.000000), 90.0, true);
			Server.CreateDoor(66, new Vector(206223.000000, 192516.000000, 1260.000000), 270.0, true);
			Server.CreateDoor(67, new Vector(205187.000000, 194281.000000, 1258.000000), 90.0, true);
			Server.CreateDoor(67, new Vector(204789.000000, 194281.000000, 1258.000000), 90.0, true);
			Server.CreateDoor(35, new Vector(-182093.000000, -40643.000000, 1065.000000), 90.0, true); // Armed&Dangerous front

		}

	}

}