using Onsharp.Events;
using Onsharp.World;

namespace OnSharp_Doors
{

	public class Pub : OnSharp_Doors
	{

		[ServerEvent(EventType.PackageStart)]
		public void OnPub()
		{

			// Desert Town 2 Pub
			Server.CreateDoor(56, new Vector(48671.000000, 133162.000000, 1477.000000), 90.0, true);
			Server.CreateDoor(57, new Vector(48671.000000, 133404.000000, 1477.000000), 90.0, true);

		}

	}

}