using Onsharp.Events;
using Onsharp.World;

namespace OnSharp_Doors
{

	public class Shooting : OnSharp_Doors
	{

		[ServerEvent(EventType.PackageStart)]
		public void OnShooting()
		{

			// Shooting range 
			Server.CreateDoor(4, new Vector(-13826.999023, 136221.046875, 1456.000000), 95.0, true); // entry
			Server.CreateDoor(60, new Vector(-13588.653320, 134657.562500, 1462.000000), -85.0, true);
			Server.CreateDoor(60, new Vector(-14220.141602, 133591.515625, 1462.000000), -175.0, true);
			Server.CreateDoor(60, new Vector(-14427.906250, 135180.828125, 1462.000000), 95.0, true);

		}

	}

}