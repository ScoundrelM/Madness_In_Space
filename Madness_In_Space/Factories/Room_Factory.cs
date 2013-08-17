using System;
using System.Collections;

namespace Madness_In_Space.Factories
{
	public class Room_Factory
	{
		public string roomID;
		public Room output;
		
		public Room_Factory(Vessel_Factory vFactory)
		{
			this.roomID = "Room " + vFactory.ticker.issueNewID();
		}
		
		public Room createRoom(Bounding_Dimensions_Property boundsIncoming, Ship_Local_Co_Ordinates_Property shipLocationIn)
		{
			//output.room.Add();
			output.room.Add ("Bounds", boundsIncoming);
			output.room.Add ("Ship Local CoOrdinates", shipLocationIn);
			output.room.Add ("Type", new Type_ID_Property("Room",""));
//			output.room.Add("Bulkheads",new Hashtable());
//			output.room.Add("Systems", new Hashtable());
//			output.room.Add("Interfaces", new Hashtable());
//			output.room.Add("Atmosphere",new Hashtable());
//			output.room.Add("Owner Vessel",new string);
			return output;
		}
	}
}
