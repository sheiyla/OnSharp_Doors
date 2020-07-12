using Onsharp.Events;
using Onsharp.World;


namespace OnSharp_Doors
{

    public class Prison : OnSharp_Doors
	{

		[ServerEvent(EventType.PackageStart)]
		public void OnPrison()
		{

			// START PRISON GATES
			Server.CreateDoor(5, new Vector(-169639.953125, 77560.062500, 1429.000000), -180.0, true);
			Server.CreateDoor(5, new Vector(-178039.968750, 66310.062500, 1429.000000), -90.0, true);
			Server.CreateDoor(5, new Vector(-183639.968750, 81060.054688, 1429.000000), 0.0, true);
			Server.CreateDoor(5, new Vector(-185039.968750, 85260.062500, 1429.000000), 0.0, true);
			// END PRISON GATES

			// START PRISON BARRIERS
			Server.CreateDoor(6, new Vector(-170377.500000, 77521.687500, 1430.000488), -90.0, true);
			Server.CreateDoor(6, new Vector(-170377.500000, 78314.453125, 1430.000488), 90.0, true);
			Server.CreateDoor(6, new Vector(-183003.406250, 85321.625000, 1430.000000), 90.0, true);
			Server.CreateDoor(6, new Vector(-183003.406250, 84525.085938, 1430.000000), -90.0, true);
			Server.CreateDoor(6, new Vector(-180144.031250, 84858.296875, 1430.000000), -90.0, true);
			Server.CreateDoor(6, new Vector(-180144.031250, 85667.890625, 1430.000000), 90.0, true);
			Server.CreateDoor(6, new Vector(-182656.843750, 80328.765625, 1430.000000), -90.0, true);
			Server.CreateDoor(6, new Vector(-182656.843750, 81125.273438, 1430.000000), 90.0, true);
			// END PRISON BARRIERS

			// START PRISON DOORS OUTSIDE
			Server.CreateDoor(3, new Vector(-170068.203125, 77587.656250, 1434.840820), 90.0, true);
			Server.CreateDoor(1, new Vector(-179133.906250, 67481.507813, 1435.000000), 180.0, true);
			Server.CreateDoor(1, new Vector(-182984.968750, 81198.992188, 1435.000000), 90.0, true);
			Server.CreateDoor(1, new Vector(-183242.906250, 84464.507813, 1435.000000), -90.0, true);
			Server.CreateDoor(1, new Vector(-178405.828125, 84532.812500, 1435.000000), -90.0, true);
			Server.CreateDoor(4, new Vector(-169602.000000, 75812.000000, 1430.000000), 0.0, true);
			Server.CreateDoor(4, new Vector(-183678.000000, 81300.000000, 1430.000000), 180.0, true);
			Server.CreateDoor(4, new Vector(-182255.000000, 79871.000000, 1430.000000), 0.0, true);
			Server.CreateDoor(4, new Vector(-180602.000000, 79396.000000, 1430.000000), 90.0, true);
			Server.CreateDoor(4, new Vector(-180602.000000, 79396.000000, 1430.000000), 90.0, true);
			Server.CreateDoor(4, new Vector(-178073.000000, 73598.000000, 1426.000000), 180.0, true);
			Server.CreateDoor(3, new Vector(-173118.000000, 75867.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(3, new Vector(-171447.000000, 81782.000000, 1530.000000), 90.0, true);
			Server.CreateDoor(3, new Vector(-180863.000000, 82754.000000, 1530.000000), 180.0, true);
			Server.CreateDoor(3, new Vector(-178762.000000, 77853.000000, 1530.000000), 180.0, true);
			Server.CreateDoor(3, new Vector(-181561.000000, 75052.000000, 1530.000000), 180.0, true);
			Server.CreateDoor(3, new Vector(-175962.000000, 74353.000000, 1530.000000), 180.0, true);
			Server.CreateDoor(4, new Vector(-175533.000000, 79635.000000, 1530.000000), -90.0, true);
			// END PRISON DOORS OUTSIDE

			// START PRISON TOWER DOORS
			Server.CreateDoor(1, new Vector(-184933.000000, 85744.000000, 2485.000000), 0.0, true);
			Server.CreateDoor(1, new Vector(-184594.000000, 85721.000000, 1435.000000), 0.0, true);
			Server.CreateDoor(1, new Vector(-169034.000000, 85910.000000, 2485.000000), -90.0, true);
			Server.CreateDoor(1, new Vector(-169057.000000, 85574.000000, 1435.000000), -90.0, true);
			Server.CreateDoor(1, new Vector(-169936.000000, 74072.000000, 2485.000000), -270.0, true);
			Server.CreateDoor(1, new Vector(-169912.000000, 74406.000000, 1435.000000), 90.0, true);
			Server.CreateDoor(1, new Vector(-179206.000000, 70895.000000, 2485.000000), -90.0, true);
			Server.CreateDoor(1, new Vector(-179345.000000, 70563.000000, 1435.000000), 90.0, true);
			Server.CreateDoor(1, new Vector(-183406.000000, 79789.000000, 2685.000000), 0.0, true);
			Server.CreateDoor(1, new Vector(-183067.000000, 79766.000000, 1635.000000), 0.0, true);
			// END PRISON TOWER DOORS

			// START PRISON FENCE DOORS OUTSIDE
			Server.CreateDoor(7, new Vector(-171158.000000, 76860.000000, 1430.000000), -90.0, true);
			Server.CreateDoor(7, new Vector(-173089.000000, 74543.000000, 1429.000000), 0.0, true);
			Server.CreateDoor(7, new Vector(-170690.000000, 74542.000000, 1430.000000), 0.0, true);
			Server.CreateDoor(7, new Vector(-171036.000000, 84092.000000, 1430.000000), 0.0, true);
			Server.CreateDoor(7, new Vector(-169057.000000, 84560.000000, 1430.000000), -90.0, true);
			Server.CreateDoor(7, new Vector(-180190.000000, 84442.000000, 1430.000000), 0.0, true);
			Server.CreateDoor(7, new Vector(-181422.000000, 83260.000000, 1430.000000), 90.0, true);
			Server.CreateDoor(7, new Vector(-181422.000000, 82410.000000, 1430.000000), 90.0, true);
			Server.CreateDoor(7, new Vector(-181422.000000, 81760.000000, 1430.000000), 90.0, true);
			Server.CreateDoor(7, new Vector(-183690.000000, 81928.000000, 1430.000000), 180.0, true);
			Server.CreateDoor(7, new Vector(-182940.000000, 82892.000000, 1432.000000), 0.0, true);
			Server.CreateDoor(7, new Vector(-184122.000000, 84410.000000, 1429.000000), 90.0, true);
			Server.CreateDoor(7, new Vector(-180669.000000, 76982.000000, 1430.000000), 90.0, true);
			Server.CreateDoor(7, new Vector(-182229.000000, 75316.000000, 1430.000000), -90.0, true);
			Server.CreateDoor(7, new Vector(-182108.000000, 74024.000000, 1430.000000), -90.0, true);
			Server.CreateDoor(7, new Vector(-180090.000000, 69278.000000, 1430.000000), -180.0, true);
			Server.CreateDoor(7, new Vector(-177990.000000, 69628.000000, 1430.000000), 180.0, true);
			Server.CreateDoor(7, new Vector(-179150.000000, 69248.000000, 1430.000000), -180.0, true);
			Server.CreateDoor(7, new Vector(-177108.000000, 81660.000000, 1430.000000), -90.0, true);
			Server.CreateDoor(7, new Vector(-176408.000000, 80210.000000, 1230.000000), -90.0, true);
			Server.CreateDoor(7, new Vector(-177340.000000, 72892.000000, 1230.000000), 0.0, true);
			Server.CreateDoor(7, new Vector(-177340.000000, 72543.000000, 1230.000000), 0.0, true);
			Server.CreateDoor(7, new Vector(-177340.000000, 72192.000000, 1230.000000), 0.0, true);
			Server.CreateDoor(7, new Vector(-177340.000000, 71842.000000, 1230.000000), 0.0, true);
			Server.CreateDoor(7, new Vector(-177340.000000, 71493.000000, 1230.000000), 0.0, true);
			Server.CreateDoor(7, new Vector(-177340.000000, 71143.000000, 1230.000000), 0.0, true);
			Server.CreateDoor(7, new Vector(-176640.000000, 71378.000000, 1430.000000), 0.0, true);
			// END PRISON FENCE DOORS OUTSIDE

			// START PRISON FENCE DOORS INTERIOR
			Server.CreateDoor(8, new Vector(-179440.000000, 79773.000000, 1886.000000), 180.0, true);
			// END PRISON FENCE DOORS INTERIOR

			// START PRISON GENERIC DOORS INTERIOR
			Server.CreateDoor(2, new Vector(-173601.000000, 76147.000000, 1530.000000), -90.0, true);
			Server.CreateDoor(2, new Vector(-174428.000000, 75457.000000, 1530.000000), 90.0, true);
			Server.CreateDoor(1, new Vector(-174126.000000, 76145.000000, 1530.000000), -90.0, true);
			Server.CreateDoor(3, new Vector(-174894.000000, 76049.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(3, new Vector(-175128.000000, 75457.000000, 1880.000000), 90.0, true);
			Server.CreateDoor(1, new Vector(-174778.000000, 74756.000000, 1880.000000), 90.0, true);
			Server.CreateDoor(2, new Vector(-174428.000000, 75457.000000, 1880.000000), 90.0, true);
			Server.CreateDoor(2, new Vector(-173836.000000, 75572.000000, 1880.000000), 180.0, true);
			Server.CreateDoor(2, new Vector(-173836.000000, 76272.000000, 1880.000000), 180.0, true);
			Server.CreateDoor(9, new Vector(-174054.000000, 76860.000000, 1880.000000), -90.0, true);
			Server.CreateDoor(9, new Vector(-175376.000000, 74780.000000, 1880.000000), 90.0, true);
			Server.CreateDoor(1, new Vector(-175303.000000, 74075.000000, 1880.000000), 90.0, true);
			Server.CreateDoor(9, new Vector(-175939.000000, 75245.000000, 1880.000000), 0.0, true);
			Server.CreateDoor(9, new Vector(-176155.000000, 75460.000000, 1880.000000), -90.0, true);
			Server.CreateDoor(3, new Vector(-174541.000000, 77799.000000, 1880.000000), 0.0, true);
			Server.CreateDoor(9, new Vector(-178039.000000, 75245.000000, 1880.000000), 0.0, true);
			Server.CreateDoor(9, new Vector(-178039.000000, 75245.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(9, new Vector(-178254.000000, 75610.000000, 1530.000000), -90.0, true);
			Server.CreateDoor(1, new Vector(-176637.000000, 77685.000000, 1880.000000), 180.0, true);
			Server.CreateDoor(3, new Vector(-176866.000000, 76157.000000, 1880.000000), 90.0, true);
			Server.CreateDoor(1, new Vector(-176752.000000, 77896.000000, 1880.000000), -90.0, true);
			Server.CreateDoor(1, new Vector(-176994.000000, 76736.000000, 1880.000000), 0.0, true);
			Server.CreateDoor(1, new Vector(-176636.000000, 78034.000000, 1880.000000), -180.0, true);
			Server.CreateDoor(1, new Vector(-178023.000000, 78149.000000, 1881.000000), 0.0, true);
			Server.CreateDoor(2, new Vector(-178044.000000, 76378.000000, 1880.000000), 0.0, true);
			Server.CreateDoor(1, new Vector(-178042.000000, 77099.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(1, new Vector(-177114.000000, 78245.000000, 1530.000000), -90.0, true);
			Server.CreateDoor(1, new Vector(-178038.000000, 78384.000000, 1530.000000), -180.0, true);
			Server.CreateDoor(9, new Vector(-174055.000000, 79660.000000, 1530.000000), -90.0, true);
			Server.CreateDoor(4, new Vector(-179678.000000, 80375.000000, 1530.000000), 90.0, true);
			Server.CreateDoor(1, new Vector(-178725.000000, 81649.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(1, new Vector(-178725.000000, 81998.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(1, new Vector(-178728.000000, 83749.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(1, new Vector(-179214.000000, 83168.000000, 1530.000000), -90.0, true);
			Server.CreateDoor(1, new Vector(-180614.000000, 83168.000000, 1530.000000), -90.0, true);
			Server.CreateDoor(2, new Vector(-179679.000000, 83525.000000, 1530.000000), 90.0, true);
			Server.CreateDoor(2, new Vector(-180729.000000, 83525.000000, 1530.000000), 90.0, true);
			Server.CreateDoor(2, new Vector(-180235.000000, 83284.000000, 1530.000000), 180.0, true);
			Server.CreateDoor(1, new Vector(-180379.000000, 82474.000000, 1530.000000), 90.0, true);
			Server.CreateDoor(1, new Vector(-179328.000000, 82474.000000, 1530.000000), 90.0, true);
			Server.CreateDoor(2, new Vector(-180154.000000, 82234.000000, 1530.000000), 180.0, true);
			Server.CreateDoor(2, new Vector(-173838.000000, 74884.000000, 1530.000000), 180.0, true);
			Server.CreateDoor(1, new Vector(-174543.000000, 75173.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(4, new Vector(-174778.000000, 74776.000000, 1530.000000), 90.0, true);
			Server.CreateDoor(1, new Vector(-175931.000000, 75174.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(9, new Vector(-176154.000000, 75461.000000, 1530.000000), -90.0, true);
			Server.CreateDoor(1, new Vector(-176178.000000, 78259.000000, 1880.000000), 90.0, true);
			Server.CreateDoor(1, new Vector(-174875.000000, 71149.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(4, new Vector(-171441.000000, 81057.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(1, new Vector(-175303.000000, 74074.000000, 1530.000000), 90.0, true);
			Server.CreateDoor(9, new Vector(-175375.000000, 74781.000000, 1530.000000), 90.0, true);
			Server.CreateDoor(1, new Vector(-173952.000000, 78945.000000, 1880.000000), -90.0, true);
			Server.CreateDoor(1, new Vector(-174314.000000, 79648.000000, 1881.000000), -90.0, true);
			// END PRISON GENERIC DOORS INTERIOR

			// START PRISON METAL FENCE DOORS INTERIOR
			Server.CreateDoor(10, new Vector(-174290.000000, 77527.000000, 1530.000000), -90.0, true);
			Server.CreateDoor(10, new Vector(-173939.000000, 77510.000000, 1530.000000), -90.0, true);
			Server.CreateDoor(10, new Vector(-176890.000000, 75624.000000, 1530.000000), 90.0, true);
			Server.CreateDoor(10, new Vector(-177089.000000, 75657.000000, 1530.000000), 270.0, true);
			Server.CreateDoor(10, new Vector(-177311.000000, 75362.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(10, new Vector(-178442.000000, 76151.000000, 1530.000000), -90.0, true);
			Server.CreateDoor(10, new Vector(-178443.000000, 76649.000000, 1530.000000), 180.0, true);
			Server.CreateDoor(10, new Vector(-178639.000000, 77500.000000, 1530.000000), 90.0, true);
			Server.CreateDoor(10, new Vector(-178042.000000, 78859.000000, 1530.000000), -90.0, true);
			Server.CreateDoor(10, new Vector(-178740.000000, 78821.000000, 1528.000000), 90.0, true);
			Server.CreateDoor(10, new Vector(-178640.000000, 81759.000000, 1530.000000), 90.0, true);
			Server.CreateDoor(10, new Vector(-178291.000000, 81862.000000, 1530.000000), 90.0, true);
			Server.CreateDoor(10, new Vector(-178469.000000, 83409.000000, 1530.000000), -90.0, true);
			Server.CreateDoor(10, new Vector(-175942.000000, 83258.976563, 1530.035889), 180.0, true);
			Server.CreateDoor(10, new Vector(-175976.000000, 83762.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(10, new Vector(-174439.000000, 78774.000000, 1530.000000), 90.0, true);
			Server.CreateDoor(10, new Vector(-173940.000000, 78808.000000, 1530.000000), -90.0, true);
			Server.CreateDoor(10, new Vector(-176990.000000, 77409.000000, 1530.000000), -90.0, true);
			Server.CreateDoor(10, new Vector(-176990.000000, 77374.000000, 1530.000000), 90.0, true);
			Server.CreateDoor(10, new Vector(-174931.000000, 75360.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(10, new Vector(-174898.000000, 74861.000000, 1530.000000), 180.0, true);
			Server.CreateDoor(10, new Vector(-175556.000000, 74475.000000, 1530.000000), 180.0, true);
			Server.CreateDoor(10, new Vector(-172438.000000, 80011.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(10, new Vector(-172438.000000, 81058.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(10, new Vector(-172749.000000, 81349.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(10, new Vector(-172749.000000, 83550.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(10, new Vector(-174148.000000, 78445.000000, 1886.000000), -90.0, true);
			// END PRISON METAL FENCE DOORS INTERIOR

			// START PRISON GUARDBOOTHS
			Server.CreateDoor(1, new Vector(-175032.000000, 84449.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(1, new Vector(-179228.000000, 74592.000000, 1530.000000), 90.0, true);
			Server.CreateDoor(1, new Vector(-176596.000000, 76705.000000, 1530.000000), 90.0, true);
			// END PRISON GUARDBOOTHS

			// START PRISON A-BLOCK CELL DOORS (Administrative Segregation, 1st Floor)
			Server.CreateDoor(11, new Vector(-175013.000000, 73822.000000, 1535.000000), 180.0, true);
			Server.CreateDoor(11, new Vector(-175014.000000, 73472.000000, 1535.000000), 180.0, true);
			Server.CreateDoor(11, new Vector(-175014.000000, 73122.000000, 1535.000000), 180.0, true);
			Server.CreateDoor(11, new Vector(-175014.000000, 72772.000000, 1535.000000), 180.0, true);
			Server.CreateDoor(11, new Vector(-175014.000000, 72422.000000, 1535.000000), 180.0, true);
			Server.CreateDoor(11, new Vector(-175014.000000, 72072.000000, 1535.000000), 180.0, true);
			Server.CreateDoor(11, new Vector(-175014.000000, 71722.000000, 1535.000000), 180.0, true);
			Server.CreateDoor(11, new Vector(-175014.000000, 71372.000000, 1535.000000), 180.0, true);
			Server.CreateDoor(12, new Vector(-175466.000000, 73823.000000, 1535.000000), 0.0, true);
			Server.CreateDoor(12, new Vector(-175466.000000, 73472.000000, 1535.000000), 0.0, true);
			Server.CreateDoor(12, new Vector(-175466.000000, 73122.000000, 1535.000000), 0.0, true);
			Server.CreateDoor(12, new Vector(-175466.000000, 72771.000000, 1535.000000), 0.0, true);
			Server.CreateDoor(12, new Vector(-175466.000000, 72422.000000, 1535.000000), 0.0, true);
			Server.CreateDoor(12, new Vector(-175466.000000, 72072.000000, 1535.000000), 0.0, true);
			Server.CreateDoor(12, new Vector(-175466.000000, 71722.000000, 1535.000000), 0.0, true);
			Server.CreateDoor(12, new Vector(-175466.000000, 71372.000000, 1535.000000), 0.0, true);
			// END PRISON A-BLOCK CELL DOORS

			// START PRISON A-BLOCK CELL DOORS (Juvenile Wing, 2nd Floor)
			Server.CreateDoor(11, new Vector(-175013.000000, 73822.000000, 1885.000000), 180.0, true);
			Server.CreateDoor(11, new Vector(-175013.000000, 73473.000000, 1885.000000), 180.0, true);
			Server.CreateDoor(11, new Vector(-175013.000000, 73122.000000, 1885.000000), 180.0, true);
			Server.CreateDoor(11, new Vector(-175013.000000, 72772.000000, 1885.000000), 180.0, true);
			Server.CreateDoor(11, new Vector(-175013.000000, 72422.000000, 1885.000000), 180.0, true);
			Server.CreateDoor(11, new Vector(-175013.000000, 72072.000000, 1885.000000), 180.0, true);
			Server.CreateDoor(11, new Vector(-175013.000000, 71722.000000, 1885.000000), 180.0, true);
			Server.CreateDoor(11, new Vector(-175013.000000, 71372.000000, 1885.000000), 180.0, true);
			Server.CreateDoor(12, new Vector(-175467.000000, 73822.000000, 1885.000000), 0.0, true);
			Server.CreateDoor(12, new Vector(-175467.000000, 73472.000000, 1885.000000), 0.0, true);
			Server.CreateDoor(12, new Vector(-175467.000000, 72772.000000, 1885.000000), 0.0, true);
			Server.CreateDoor(12, new Vector(-175467.000000, 72422.000000, 1885.000000), 0.0, true);
			Server.CreateDoor(12, new Vector(-175467.000000, 72072.000000, 1885.000000), 0.0, true);
			Server.CreateDoor(12, new Vector(-175467.000000, 71722.000000, 1885.000000), 0.0, true);
			Server.CreateDoor(12, new Vector(-175467.000000, 71372.000000, 1885.000000), 0.0, true);
			Server.CreateDoor(12, new Vector(-175702.000000, 71033.000000, 1885.000000), 90.0, true);
			Server.CreateDoor(12, new Vector(-175352.000000, 71033.000000, 1885.000000), 90.0, true);
			Server.CreateDoor(12, new Vector(-175002.000000, 71033.000000, 1885.000000), 90.0, true);
			Server.CreateDoor(12, new Vector(-174652.000000, 71033.000000, 1885.000000), 90.0, true);
			// END PRISON A-BLOCK CELL DOORS

			// START PRISON B-BLOCK CELL DOORS
			// 1st Floor
			Server.CreateDoor(13, new Vector(-175939.000000, 76510.000000, 1530.000000), 90.0, true);
			Server.CreateDoor(13, new Vector(-175590.000000, 76510.000000, 1530.000000), 90.0, true);
			Server.CreateDoor(13, new Vector(-175239.000000, 76510.000000, 1530.000000), 90.0, true);
			Server.CreateDoor(13, new Vector(-174890.000000, 76511.000000, 1530.000000), 180.0, true);
			Server.CreateDoor(13, new Vector(-174890.000000, 76861.000000, 1530.000000), 180.0, true);
			Server.CreateDoor(13, new Vector(-174891.000000, 77210.000000, 1530.000000), -90.0, true);
			Server.CreateDoor(13, new Vector(-175241.000000, 77210.000000, 1530.000000), -90.0, true);
			Server.CreateDoor(13, new Vector(-175591.000000, 77210.000000, 1530.000000), -90.0, true);
			Server.CreateDoor(13, new Vector(-175941.000000, 77210.000000, 1530.000000), -90.0, true);
			// 2nd Floor
			Server.CreateDoor(13, new Vector(-175939.000000, 76510.000000, 1880.000000), 90.0, true);
			Server.CreateDoor(13, new Vector(-175590.000000, 76510.000000, 1880.000000), 90.0, true);
			Server.CreateDoor(13, new Vector(-175239.000000, 76510.000000, 1880.000000), 90.0, true);
			Server.CreateDoor(13, new Vector(-174890.000000, 76511.000000, 1880.000000), 180.0, true);
			Server.CreateDoor(13, new Vector(-174890.000000, 76861.000000, 1880.000000), 180.0, true);
			Server.CreateDoor(13, new Vector(-174891.000000, 77210.000000, 1880.000000), -90.0, true);
			Server.CreateDoor(13, new Vector(-175241.000000, 77210.000000, 1880.000000), -90.0, true);
			Server.CreateDoor(13, new Vector(-175591.000000, 77210.000000, 1880.000000), -90.0, true);
			Server.CreateDoor(13, new Vector(-175941.000000, 77210.000000, 1880.000000), -90.0, true);
			Server.CreateDoor(13, new Vector(-176291.000000, 77210.000000, 1880.000000), -90.0, true);
			// END PRISON B-BLOCK CELL DOORS

			// START PRISON C-BLOCK CELL DOORS
			// 1st Floor
			Server.CreateDoor(15, new Vector(-178742.000000, 75610.000000, 1531.000000), -90.0, true);
			Server.CreateDoor(16, new Vector(-179437.000000, 75610.000000, 1531.000000), -90.0, true);
			Server.CreateDoor(15, new Vector(-179443.000000, 75610.000000, 1531.000000), -90.0, true);
			Server.CreateDoor(16, new Vector(-180138.000000, 75610.000000, 1531.000000), -90.0, true);
			Server.CreateDoor(15, new Vector(-180142.000000, 75610.000000, 1531.000000), -90.0, true);
			Server.CreateDoor(16, new Vector(-180838.000000, 75610.000000, 1531.000000), -90.0, true);
			Server.CreateDoor(15, new Vector(-180842.000000, 75610.000000, 1531.000000), -90.0, true);
			Server.CreateDoor(16, new Vector(-181538.000000, 75610.000000, 1531.000000), -90.0, true);
			Server.CreateDoor(15, new Vector(-181538.000000, 74610.000000, 1530.000000), 90.0, true);
			Server.CreateDoor(16, new Vector(-180841.000000, 74610.000000, 1530.000000), 90.0, true);
			Server.CreateDoor(15, new Vector(-180838.000000, 74610.000000, 1530.000000), 90.0, true);
			Server.CreateDoor(16, new Vector(-180142.000000, 74610.000000, 1530.000000), 90.0, true);
			Server.CreateDoor(15, new Vector(-180138.000000, 74610.000000, 1530.000000), 90.0, true);
			Server.CreateDoor(16, new Vector(-179442.000000, 74610.000000, 1530.000000), 90.0, true);
			Server.CreateDoor(15, new Vector(-178738.000000, 74610.000000, 1530.000000), 90.0, true);
			Server.CreateDoor(16, new Vector(-178042.000000, 74610.000000, 1530.000000), 90.0, true);
			// 2nd Floor
			Server.CreateDoor(15, new Vector(-178742.000000, 75610.000000, 1881.000000), -90.0, true);
			Server.CreateDoor(16, new Vector(-178742.000000, 75610.000000, 1881.000000), -90.0, true);
			Server.CreateDoor(15, new Vector(-179443.000000, 75610.000000, 1881.000000), -90.0, true);
			Server.CreateDoor(16, new Vector(-180138.000000, 75610.000000, 1881.000000), -90.0, true);
			Server.CreateDoor(15, new Vector(-180142.000000, 75610.000000, 1881.000000), -90.0, true);
			Server.CreateDoor(16, new Vector(-180838.000000, 75610.000000, 1881.000000), -90.0, true);
			Server.CreateDoor(15, new Vector(-180842.000000, 75610.000000, 1881.000000), -90.0, true);
			Server.CreateDoor(16, new Vector(-181538.000000, 75610.000000, 1881.000000), -90.0, true);
			Server.CreateDoor(15, new Vector(-181538.000000, 74610.000000, 1881.000000), 90.0, true);
			Server.CreateDoor(16, new Vector(-180841.000000, 74610.000000, 1881.000000), 90.0, true);
			Server.CreateDoor(15, new Vector(-180838.000000, 74610.000000, 1881.000000), 90.0, true);
			Server.CreateDoor(16, new Vector(-180142.000000, 74610.000000, 1881.000000), 90.0, true);
			Server.CreateDoor(15, new Vector(-180138.000000, 74610.000000, 1881.000000), 90.0, true);
			Server.CreateDoor(16, new Vector(-179442.000000, 74610.000000, 1881.000000), 90.0, true);
			Server.CreateDoor(15, new Vector(-178738.000000, 74610.000000, 1881.000000), 90.0, true);
			Server.CreateDoor(16, new Vector(-178042.000000, 74610.000000, 1881.000000), 90.0, true);
			Server.CreateDoor(16, new Vector(-178738.000000, 75610.000000, 1880.000000), -90.0, true);
			Server.CreateDoor(15, new Vector(-179438.000000, 74610.000000, 1880.000000), 90.0, true);
			Server.CreateDoor(16, new Vector(-178742.000000, 74610.000000, 1880.000000), 90.0, true);
			// END PRISON C-BLOCK CELL DOORS

			// START PRISON D-BLOCK CELL DOORS
			// 1st Floor
			Server.CreateDoor(13, new Vector(-174739.000000, 80859.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(13, new Vector(-174739.000000, 81209.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(14, new Vector(-174740.000000, 81211.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(14, new Vector(-174740.000000, 81909.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(13, new Vector(-174740.000000, 82609.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(13, new Vector(-174740.000000, 83310.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(14, new Vector(-174740.000000, 82610.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(14, new Vector(-173697.000000, 80861.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(14, new Vector(-173697.000000, 81211.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(14, new Vector(-173697.000000, 81911.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(14, new Vector(-173697.000000, 82611.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(14, new Vector(-173697.000000, 83311.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(13, new Vector(-173697.000000, 83309.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(13, new Vector(-173697.000000, 82609.000000, 1530.000000), 0.0, true);
			Server.CreateDoor(13, new Vector(-173697.000000, 81909.000000, 1530.000000), 0.0, true);
			// 2nd Floor
			Server.CreateDoor(14, new Vector(-173697.000000, 80861.000000, 1880.000000), 0.0, true);
			Server.CreateDoor(14, new Vector(-173697.000000, 81211.000000, 1880.000000), 0.0, true);
			Server.CreateDoor(14, new Vector(-173697.000000, 81911.000000, 1880.000000), 0.0, true);
			Server.CreateDoor(14, new Vector(-173697.000000, 82611.000000, 1880.000000), 0.0, true);
			Server.CreateDoor(14, new Vector(-173697.000000, 83311.000000, 1880.000000), 0.0, true);
			Server.CreateDoor(13, new Vector(-173697.000000, 83309.000000, 1880.000000), 0.0, true);
			Server.CreateDoor(13, new Vector(-173697.000000, 82609.000000, 1880.000000), 0.0, true);
			Server.CreateDoor(13, new Vector(-173697.000000, 81909.000000, 1880.000000), 0.0, true);
			// END PRISON D-BLOCK CELL DOORS

		}

	}

}