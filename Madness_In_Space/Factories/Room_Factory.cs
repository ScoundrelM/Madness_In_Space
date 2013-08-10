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
		
		public Room createRoom()
		{
			//output.room.Add();
			output.room.Add ("Bounds", new Bounding_Dimensions_Property(1,1,1) );
			output.room.Add ("Ship Local CoOrdinates", new Ship_Local_Co_Ordinates_Property("",1,1,1,1,1,1));
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
