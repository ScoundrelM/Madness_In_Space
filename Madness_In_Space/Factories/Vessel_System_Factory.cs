using System;

namespace Madness_In_Space
{
	public class Vessel_System_Factory
	{
		public Vessel_System output;
		
		public Vessel_System_Factory(Room room, Vessel_Factory vFactory)
		{
			
		}
		
		public void newVesselSystem(string typeIn, Vessel_Factory vFactory, Vessel playerVessel, Room roomIn)
		{
			Vessel_System_Type_Setter vTypeStats = new Vessel_System_Type_Setter (typeIn);
			
			output = new Vessel_System();
			
			//add vessel system properties here.
			
			vFactory.addSystem(output,roomIn);
		}
	}
}
