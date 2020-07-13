using Onsharp;
using Onsharp.World;

namespace OnSharp_Doors
{

    public class Police : OnSharp_Doors
	{

		public static void OnPolice(IServer Server)
		{

			// PD Front Entrance
			Server.CreateDoor(82, new Vector(170628.875000, 194640.906250, 1298.960938), 90.0, true);
			Server.CreateDoor(82, new Vector(170214.875000, 194106.906250, 1298.960938), 180.0, true);

			// PD Interior
			Server.CreateDoor(2, new Vector(170567.000000, 193254.000000, 1377.000000), 0.0, true);
			Server.CreateDoor(1, new Vector(170854.000000, 193139.000000, 1377.000000), 180.0, true);
			Server.CreateDoor(2, new Vector(170854.000000, 192128.000000, 1377.000000), 180.0, true);
			Server.CreateDoor(2, new Vector(170854.000000, 191486.000000, 1377.000000), 180.0, true);
			Server.CreateDoor(2, new Vector(171255.000000, 191157.000000, 1377.000000), 270.0, true);
			Server.CreateDoor(1, new Vector(171155.000000, 194088.031250, 1299.000000), 180.0, true);
			Server.CreateDoor(1, new Vector(171161.000000, 194317.000000, 1299.000000), 0.0, true);
			Server.CreateDoor(1, new Vector(170597.000000, 193698.031250, 1807.000000), 90.0, true);
			Server.CreateDoor(1, new Vector(170826.000000, 193692.031250, 1807.000000), -90.0, true);
			Server.CreateDoor(2, new Vector(170568.000000, 193120.031250, 1807.000000), 0.0, true);
			Server.CreateDoor(2, new Vector(171209.000000, 192916.031250, 1807.000000), 90.0, true);
			Server.CreateDoor(2, new Vector(171438.000000, 192910.031250, 1807.000000), 270.0, true);
			Server.CreateDoor(2, new Vector(171914.000000, 191940.031250, 1807.000000), 90.0, true);
			Server.CreateDoor(2, new Vector(172143.000000, 191934.031250, 1807.000000), 270.0, true);
			Server.CreateDoor(2, new Vector(171846.984375, 191752.031250, 1807.000000), 0.0, true);
			Server.CreateDoor(2, new Vector(171841.000000, 191523.031250, 1807.000000), 180.0, true);
			Server.CreateDoor(2, new Vector(172195.000000, 192525.031250, 1807.000000), 180.0, true);
			Server.CreateDoor(2, new Vector(172195.000000, 193415.031250, 1807.000000), 180.0, true);
			Server.CreateDoor(1, new Vector(171849.000000, 193529.031250, 1807.000000), 0.0, true);
			Server.CreateDoor(1, new Vector(171446.000000, 193670.000000, 1228.000000), 90.0, true);
			Server.CreateDoor(1, new Vector(171446.000000, 193138.000000, 1228.000000), 90.0, true);
			Server.CreateDoor(1, new Vector(171805.000000, 193138.000000, 1228.000000), 90.0, true);
			Server.CreateDoor(1, new Vector(171805.000000, 193671.000000, 1227.000000), 90.0, true);
			Server.CreateDoor(1, new Vector(171446.000000, 192840.000000, 1227.000000), 90.0, true);
			Server.CreateDoor(1, new Vector(172399.000000, 192840.000000, 1227.000000), 90.0, true);
			Server.CreateDoor(1, new Vector(172203.000000, 194080.000000, 1228.000000), 180.0, true);
			Server.CreateDoor(1, new Vector(172627.000000, 193152.000000, 1226.500000), 90.0, true);
			Server.CreateDoor(1, new Vector(172855.500000, 193146.000000, 1226.500000), 270.0, true);
			Server.CreateDoor(1, new Vector(172757.000000, 192377.000000, 1226.500000), 90.0, true);
			Server.CreateDoor(1, new Vector(172985.500000, 192371.000000, 1226.500000), 270.0, true);
			Server.CreateDoor(14, new Vector(171685.000000, 193567.000000, 1807.000000), 90.0, true);
			Server.CreateDoor(14, new Vector(171240.000000, 193576.000000, 1807.000000), 180.0, true);

			// PD Side/Rear Entrance
			Server.CreateDoor(83, new Vector(171961.500000, 194374.000000, 1228.000000), 90.0, true);
			Server.CreateDoor(83, new Vector(173480.500000, 192221.000000, 1227.000000), 0.0, true);
			Server.CreateDoor(83, new Vector(173400.000000, 193136.000000, 1227.000000), -90.0, true);

			// PD Rear Entrance 4Door
			Server.CreateDoor(84, new Vector(173151.000000, 192956.000000, 1226.500000), 90.0, true);
			Server.CreateDoor(84, new Vector(173143.000000, 192723.000000, 1226.500000), 270.0, true);
			Server.CreateDoor(84, new Vector(173151.000000, 192715.000000, 1226.500000), 90.0, true);
			Server.CreateDoor(84, new Vector(173143.000000, 192482.000000, 1226.500000), 270.0, true);

			// PD Garage Doors
			Server.CreateDoor(85, new Vector(173216.500000, 194385.000000, 1146.000000), -180.0, true);
			Server.CreateDoor(85, new Vector(173460.000000, 190688.000000, 1146.000000), 90.0, true);

			// Berrier
			Server.CreateDoor(6, new Vector(172886.000000, 195394.000000, 1209.000000), 180.0, true);
			Server.CreateDoor(6, new Vector(171501.000000, 189778.000000, 1209.000000), -90.0, true);

		}

    }

}