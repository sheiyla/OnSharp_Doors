using Onsharp.Events;
using Onsharp.World;

namespace OnSharp_Doors
{

	public class Other : OnSharp_Doors
	{

		[ServerEvent(EventType.PackageStart)]
		public void OnOther()
		{

			// Desert Town Laundromat
			Server.CreateDoor(44, new Vector(-21119.892578, -15522.234375, 1966.448853), -160.0, true);
			Server.CreateDoor(25, new Vector(-20668.789063, -16711.550781, 1965.000000), -70.0, true);

			// More Houes Doors
			Server.CreateDoor(20, new Vector(-178929.000000, -55734.000000, 1136.000000), 90.0, true);
			Server.CreateDoor(20, new Vector(-183854.000000, -55734.000000, 1136.000000), 90.0, true);
			Server.CreateDoor(20, new Vector(-187989.000000, -55734.000000, 1136.000000), 90.0, true);
			Server.CreateDoor(20, new Vector(-193351.000000, -53869.000000, 1142.000000), 180.0, true);
			Server.CreateDoor(20, new Vector(-187398.000000, -59013.000000, 1136.000000), -90.0, true);
			Server.CreateDoor(20, new Vector(-184737.000000, -59543.000000, 1142.000000), -180.0, true);
			Server.CreateDoor(20, new Vector(-180300.000000, -58908.000000, 1162.000000), -90.0, true);
			Server.CreateDoor(20, new Vector(-184564.000000, -62479.000000, 1127.000000), 180.0, true);
			Server.CreateDoor(20, new Vector(-181573.000000, -63059.000000, 1131.000000), 90.0, true);
			Server.CreateDoor(20, new Vector(-188044.000000, -62758.000000, 1136.000000), 90.0, true);
			Server.CreateDoor(21, new Vector(-180607.000000, -59875.000000, 1163.000000), 90.0, true);
			Server.CreateDoor(21, new Vector(-178481.000000, -54904.000000, 1136.000000), -90.0, true);
			Server.CreateDoor(22, new Vector(-183406.000000, -54904.000000, 1136.000000), -90.0, true);
			Server.CreateDoor(22, new Vector(-187541.000000, -54904.000000, 1136.000000), -90.0, true);
			Server.CreateDoor(21, new Vector(-194321.000000, -53563.000000, 1142.000000), 0.0, true);
			Server.CreateDoor(21, new Vector(-187596.000000, -61929.000000, 1136.000000), -9.0, true);
			Server.CreateDoor(20, new Vector(-180113.281250, -83168.921875, 1645.000000), 92.0, true);
			Server.CreateDoor(20, new Vector(-172624.250000, -88277.867188, 1502.000000), -26.0, true);
			Server.CreateDoor(22, new Vector(-172194.531250, -89294.812500, 1502.000000), 154.0, true);
			Server.CreateDoor(25, new Vector(-181899.000000, -66559.000000, 1051.000000), 0.0, true); // laundromat back
			Server.CreateDoor(44, new Vector(-180632.000000, -66635.000000, 1054.000000), 90.0, true); // laundromat front
			Server.CreateDoor(43, new Vector(-172164.000000, -64116.000000, 1112.000000), -90.0, true);
			Server.CreateDoor(43, new Vector(-171798.000000, -64285.000000, 1112.000000), 0.0, true);
			Server.CreateDoor(43, new Vector(-171571.000000, -64523.000000, 1112.000000), -90.0, true);
			Server.CreateDoor(43, new Vector(-171795.000000, -63149.000000, 1432.000000), 180.0, true);
			Server.CreateDoor(43, new Vector(-172174.000000, -63650.000000, 1432.000000), 270.0, true);
			Server.CreateDoor(43, new Vector(-172174.000000, -64051.000000, 1432.000000), 270.0, true);
			Server.CreateDoor(43, new Vector(-172426.000000, -63654.000000, 1432.000000), 90.0, true);
			Server.CreateDoor(43, new Vector(-173426.000000, -63654.000000, 1432.000000), 90.0, true);
			Server.CreateDoor(43, new Vector(-173564.000000, -64051.000000, 1432.000000), 270.0, true);
			Server.CreateDoor(43, new Vector(-174189.000000, -63887.000000, 1111.000000), 0.0, true);
			Server.CreateDoor(43, new Vector(-172987.000000, -63886.000000, 1111.000000), 0.0, true);
			Server.CreateDoor(43, new Vector(-173363.000000, -64113.000000, 1111.000000), -90.0, true);
			Server.CreateDoor(43, new Vector(-172988.000000, -63485.000000, 1111.000000), 0.0, true);
			Server.CreateDoor(36, new Vector(-180794.000000, -40995.000000, 1065.000000), 0.0, true); // A&D back door
			Server.CreateDoor(18, new Vector(211200.000000, 94175.000000, 1282.000000), -180.0, true); // Diner Physics Door 1
			Server.CreateDoor(18, new Vector(211308.000000, 92569.000000, 1282.000000), 0.0, true); // Diner Physics Door 2
			Server.CreateDoor(26, new Vector(97540.000000, 121148.000000, 6335.000000), 0.0, true); // Scenic View Restroom 1
			Server.CreateDoor(26, new Vector(96840.000000, 121148.000000, 6335.000000), 180.0, true); // Scenic View Restroom 2

		}

	}

}