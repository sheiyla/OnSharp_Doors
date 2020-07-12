using Onsharp.Events;
using Onsharp.World;

namespace OnSharp_Doors
{

	public class House : OnSharp_Doors
	{

		[ServerEvent(EventType.PackageStart)]
		public void OnHouse()
		{

			// City houses 1
			Server.CreateDoor(23, new Vector(216289.000000, 166768.000000, 1297.000000), 90.0, true);
			Server.CreateDoor(23, new Vector(212728.000000, 166980.000000, 1300.000000), 90.0, true);
			Server.CreateDoor(21, new Vector(216178.000000, 168302.000000, 1297.000000), -90.0, true);
			Server.CreateDoor(24, new Vector(216138.000000, 167899.000000, 1297.000000), -90.0, true);
			Server.CreateDoor(24, new Vector(212683.000000, 167192.000000, 1301.000000), 0.0, true);
			Server.CreateDoor(22, new Vector(213177.000000, 167813.000000, 1301.000000), -90.0, true);
			Server.CreateDoor(22, new Vector(211646.000000, 171114.000000, 1303.000000), 90.0, true);
			Server.CreateDoor(23, new Vector(212094.000000, 171944.000000, 1302.000000), -90.0, true);
			Server.CreateDoor(24, new Vector(212141.000000, 171732.000000, 1303.000000), 180.0, true);
			Server.CreateDoor(23, new Vector(215638.000000, 172176.000000, 1295.000000), -90.0, true);
			Server.CreateDoor(24, new Vector(214773.000000, 171476.000000, 1295.000000), -90.0, true);
			Server.CreateDoor(41, new Vector(217059.000000, 171935.000000, 1215.000000), 180.0, true);
			Server.CreateDoor(41, new Vector(213558.000000, 171935.000000, 1215.000000), 180.0, true);
			Server.CreateDoor(41, new Vector(211319.000000, 166962.000000, 1215.000000), 0.0, true);
			Server.CreateDoor(41, new Vector(214824.000000, 166962.000000, 1215.000000), 0.0, true);

			// City houses 2
			Server.CreateDoor(23, new Vector(162870.000000, 211647.000000, 1313.000000), -90.0, true);
			Server.CreateDoor(24, new Vector(163233.000000, 211441.000000, 1313.000000), 180.0, true);
			Server.CreateDoor(23, new Vector(159179.000000, 211638.000000, 1295.000000), -90.0, true);
			Server.CreateDoor(24, new Vector(159122.000000, 210974.000000, 1295.000000), -180.0, true);
			Server.CreateDoor(21, new Vector(163420.000000, 215213.000000, 1311.000000), 90.0, true);
			Server.CreateDoor(24, new Vector(163477.000000, 215877.000000, 1312.000000), 0.0, true);
			Server.CreateDoor(23, new Vector(159112.000000, 215228.000000, 1309.000000), -90.0, true);
			Server.CreateDoor(24, new Vector(159354.000000, 215701.000000, 1309.000000), 0.0, true);
			Server.CreateDoor(23, new Vector(155434.000000, 215472.000000, 1314.000000), -180.0, true);
			Server.CreateDoor(24, new Vector(155152.000000, 215273.000000, 1313.000000), -180.0, true);
			Server.CreateDoor(22, new Vector(154466.000000, 215781.000000, 1314.000000), 0.0, true);
			Server.CreateDoor(25, new Vector(154919.000000, 215779.000000, 1036.000000), 0.0, true);
			Server.CreateDoor(23, new Vector(159174.000000, 218746.000000, 1312.000000), -90.0, true);
			Server.CreateDoor(24, new Vector(159116.000000, 217933.000000, 1312.000000), 180.0, true);
			Server.CreateDoor(21, new Vector(158792.000000, 222885.000000, 1309.000000), 180.0, true);
			Server.CreateDoor(24, new Vector(159921.000000, 222735.000000, 1309.000000), 0.0, true);
			Server.CreateDoor(22, new Vector(160322.000000, 222774.000000, 1309.000000), 0.0, true);
			Server.CreateDoor(23, new Vector(162157.000000, 222370.000000, 1309.000000), 90.0, true);
			Server.CreateDoor(24, new Vector(162465.000000, 223340.000000, 1309.000000), -90.0, true);
			Server.CreateDoor(23, new Vector(164809.000000, 222136.000000, 1308.000000), 90.0, true);
			Server.CreateDoor(24, new Vector(164758.000000, 222527.000000, 1308.000000), 0.0, true);
			Server.CreateDoor(23, new Vector(165337.000000, 218768.000000, 1316.000000), -90.0, true);
			Server.CreateDoor(41, new Vector(160607.000000, 211848.000000, 1245.000000), 180.0, true);
			Server.CreateDoor(41, new Vector(161978.000000, 215099.000000, 1245.000000), 0.0, true);
			Server.CreateDoor(41, new Vector(155309.000000, 217108.000000, 1245.000000), 90.0, true);
			Server.CreateDoor(41, new Vector(160614.000000, 218698.000000, 1245.000000), 180.0, true);
			Server.CreateDoor(41, new Vector(166781.000000, 218698.000000, 1245.000000), 180.0, true);
			Server.CreateDoor(41, new Vector(167559.000000, 221959.000000, 1245.000000), 0.0, true);

			// Desert Town Houses and Garages
			Server.CreateDoor(41, new Vector(-25864.644531, 4765.184082, 1958.000000), 20.0, true);
			Server.CreateDoor(41, new Vector(-26143.248047, 709.295044, 1978.000000), -70.0, true);
			Server.CreateDoor(41, new Vector(-31693.007813, -2401.432861, 1965.000000), -160.0, true);
			Server.CreateDoor(20, new Vector(-27359.089844, 4023.333984, 2068.000000), 200.0, true);
			Server.CreateDoor(20, new Vector(-25719.566406, -615.683594, 2065.000000), 20.0, true);
			Server.CreateDoor(20, new Vector(-30048.773438, -1784.869019, 2064.000000), -70.0, true);
			Server.CreateDoor(21, new Vector(-29388.572266, -7724.256836, 2064.000000), 20.0, true);
			Server.CreateDoor(24, new Vector(-27539.611328, 3908.139893, 2067.000000), 110.0, true);
			Server.CreateDoor(24, new Vector(-25538.179688, -500.182709, 2065.0), -70.0, true);
			Server.CreateDoor(21, new Vector(-24787.996094, -753.822266, 2065.000000), -160.0, true);
			Server.CreateDoor(21, new Vector(-29420.884766, -3184.974365, 2065.000000), 110.0, true);
			Server.CreateDoor(24, new Vector(-29520.558594, -2795.500244, 2064.000000), 110.0, true);
			Server.CreateDoor(24, new Vector(-29203.316406, -7612.893066, 2064.000000), -70.0, true);
			Server.CreateDoor(54, new Vector(-26797.480469, 3300.743652, 2014.000000), 20.0, true);
			Server.CreateDoor(54, new Vector(-26633.103516, -1060.019409, 2014.000000), 110.0, true);

			// Town level mobile houses
			Server.CreateDoor(40, new Vector(-161386.000000, -39784.500000, 1085.000000), 0.0, true);
			Server.CreateDoor(40, new Vector(-162288.000000, -36656.000000, 1085.000000), 0.0, true);
			Server.CreateDoor(40, new Vector(-158468.000000, -39638.199219, 1085.000000), 0.0, true);
			Server.CreateDoor(40, new Vector(-158320.000000, -36831.199219, 1085.000000), -90.0, true);
			Server.CreateDoor(40, new Vector(-155095.000000, -38000.199219, 1085.000000), -90.0, true);
			Server.CreateDoor(40, new Vector(-155325.000000, -35741.000000, 1085.000000), -180.0, true);

			// House doors
			Server.CreateDoor(20, new Vector(-171043.000000, -33401.000000, 1131.000000), 90.0, true);
			Server.CreateDoor(23, new Vector(-171090.000000, -33189.000000, 1130.000000), 0.0, true);
			Server.CreateDoor(20, new Vector(-169720.000000, -45762.000000, 1141.000000), 270.0, true);
			Server.CreateDoor(22, new Vector(-170169.000000, -46594.000000, 1141.000000), 90.0, true);
			Server.CreateDoor(24, new Vector(-169674.000000, -45973.000000, 1142.000000), 180.0, true);
			Server.CreateDoor(20, new Vector(-174799.000000, -36578.000000, 1129.000000), 0.0, true);
			Server.CreateDoor(23, new Vector(-174097.000000, -37446.000000, 1129.000000), 0.0, true);
			Server.CreateDoor(23, new Vector(-174380.000000, -36595.000000, 1468.000000), 0.0, true);
			Server.CreateDoor(23, new Vector(-174139.000000, -37072.000000, 1467.000000), 90.0, true);
			Server.CreateDoor(20, new Vector(-177823.000000, -37014.000000, 1139.000000), 180.0, true);
			Server.CreateDoor(23, new Vector(-178293.000000, -36769.000000, 1139.000000), 90.0, true);
			Server.CreateDoor(20, new Vector(-177842.000000, -41749.000000, 1137.000000), 180.0, true);
			Server.CreateDoor(23, new Vector(-178502.000000, -41690.000000, 1137.000000), 90.0, true);
			Server.CreateDoor(21, new Vector(-174179.000000, -41970.000000, 1129.000000), 90.0, true);
			Server.CreateDoor(20, new Vector(-174585.000000, -46782.000000, 1150.000000), 0.0, true);
			Server.CreateDoor(20, new Vector(-177721.000000, -45803.000000, 1140.000000), -90.0, true);
			Server.CreateDoor(23, new Vector(-177673.000000, -46192.000000, 1140.000000), 180.0, true);
			Server.CreateDoor(21, new Vector(-177532.000000, -49729.000000, 1145.000000), 180.0, true);
			Server.CreateDoor(23, new Vector(-178660.000000, -49881.000000, 1146.000000), 0.0, true);
			Server.CreateDoor(22, new Vector(-179061.000000, -49841.000000, 1146.000000), 0.0, true);

		}

	}

}