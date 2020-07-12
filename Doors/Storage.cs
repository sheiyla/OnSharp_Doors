using Onsharp.Events;
using Onsharp.World;

namespace OnSharp_Doors
{

	public class Storage : OnSharp_Doors
	{

		[ServerEvent(EventType.PackageStart)]
		public void OnStorage()
		{

			// Big Desert Storage Hall #1 Rolldoors and entry doors
			Server.CreateDoor(51, new Vector(-17316.492188, -29117.455078, 2100.000000), -70.0, true);
			Server.CreateDoor(51, new Vector(-17689.808594, -29255.462891, 2100.000000), -70.0, true);
			Server.CreateDoor(51, new Vector(-18443.439453, -29529.759766, 2100.000000), -70.0, true);
			Server.CreateDoor(51, new Vector(-18819.312500, -29666.570313, 2100.000000), -70.0, true);
			Server.CreateDoor(51, new Vector(-19570.125000, -29939.845703, 2100.000000), -70.0, true);
			Server.CreateDoor(51, new Vector(-19945.994141, -30076.646484, 2100.000000), -70.0, true);
			Server.CreateDoor(52, new Vector(-15487.943359, -31219.060547, 2102.000000), -160.0, true);
			Server.CreateDoor(52, new Vector(-15762.240234, -30465.431641, 2102.000000), -160.0, true);
			Server.CreateDoor(52, new Vector(-16035.851563, -29713.685547, 2102.000000), -160.0, true);
			Server.CreateDoor(53, new Vector(-16461.470703, -28525.568359, 2002.000000), 20.0, true);
			Server.CreateDoor(53, new Vector(-16515.560547, -28815.556641, 2103.000000), -70.0, true);

			// Big Desert Storage Hall #2 Rolldoors and entry doors
			Server.CreateDoor(51, new Vector(-14959.986328, -35591.933594, 2100.000000), -70.0, true);
			Server.CreateDoor(51, new Vector(-15333.303711, -35729.941406, 2100.000000), -70.0, true);
			Server.CreateDoor(51, new Vector(-16086.931641, -36004.234375, 2100.000000), -70.0, true);
			Server.CreateDoor(51, new Vector(-16462.798828, -36141.046875, 2100.000000), -70.0, true);
			Server.CreateDoor(51, new Vector(-17213.611328, -36414.320313, 2100.000000), -70.0, true);
			Server.CreateDoor(51, new Vector(-17589.480469, -36551.121094, 2100.000000), -70.0, true);
			Server.CreateDoor(52, new Vector(-13133.145508, -37688.835938, 2102.000000), -160.0, true);
			Server.CreateDoor(52, new Vector(-13406.758789, -36937.089844, 2102.000000), -160.0, true);
			Server.CreateDoor(52, new Vector(-13680.027344, -36186.277344, 2102.000000), -160.0, true);
			Server.CreateDoor(53, new Vector(-14104.964844, -35000.050781, 2002.000000), 20.0, true);
			Server.CreateDoor(53, new Vector(-14159.054688, -35290.035156, 2103.000000), -70.0, true);

		}

	}

}