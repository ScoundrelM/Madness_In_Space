using System;

namespace Madness_In_Space.Factories
{
	public class Room_Factory
	{
		public string roomID;
		
		public Room_Factory(Vessel_Factory vFactory)
		{
			this.roomID = "Room " + vFactory.ticker.issueNewID();
		}
	}
}
