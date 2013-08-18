using System;
using System.Collections;
using System.Collections.Generic;

namespace Madness_In_Space.Factories
{
	public class Room_Factory
	{
		public Room output;
		
		public Room_Factory(Vessel_Factory vFactory)
		{
			//this.roomID = "Room " + vFactory.ticker.issueNewID();
		}
		
		public void createRoom( Vessel playerVessel, Vessel_Factory vFactory, Bounding_Dimensions_Property boundsIncoming, Ship_Local_Co_Ordinates_Property shipLocationIn, string typeIn)
		{
			//output.room.Add();
			output.roomProperties.Add ("Bounds", boundsIncoming);
			output.roomProperties.Add ("Ship Local CoOrdinates", shipLocationIn);
			output.roomProperties.Add ("Type", new Type_ID_Property("Room", typeIn));
			output.roomProperties.Add("Unique ID", new Unique_ID(vFactory)  );
			output.roomProperties.Add("Bulkheads",new List<Bulkhead>());
			output.roomProperties.Add("Systems", new List<Vessel_System>());
			output.roomProperties.Add("Interfaces", new List<InfrastructureInterface>());
			output.roomProperties.Add("Atmosphere",new Atmosphere());

			vFactory.addRoom(output, playerVessel);
		}
	}
}
