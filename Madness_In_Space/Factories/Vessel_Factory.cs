using System;
using System.Collections.Generic;
using System.Collections;

namespace Madness_In_Space
{

	public class Vessel_Factory
	{
		public IDTicker ticker;
		public string vesselName;

		public Vessel_Factory(string vName)
		{
			this.vesselName = vName;
			this.ticker = new IDTicker();
		}

		public Vessel createNewVessel(string vType)
		{
		
			Vessel_Type_Setter typeStats = new Vessel_Type_Setter(vType);
			Vessel output = new Vessel();
			
			output.vesselProperties.Add("Unique ID", vType + " " + ticker.issueNewID());
			output.vesselProperties.Add("Name",vesselName);
			output.vesselProperties.Add("Type",new Type_ID_Property("Vessel", vType));
			output.vesselProperties.Add("Room Budget", typeStats.roomBudget);
			output.vesselProperties.Add("Banned Rooms", typeStats.bannedRooms);
			output.vesselProperties.Add("Required Rooms",typeStats.requiredRooms);
			output.vesselProperties.Add("Available Rooms",typeStats.availableRooms);
			output.vesselProperties.Add("Type Description",typeStats.typeDescription);
			output.vesselProperties.Add("Rooms", new List<Room>());
			
			output.vesselProperties.Add("Bounds",new Bounding_Dimensions_Property(typeStats.maxXBounds,typeStats.maxYBounds,typeStats.maxZBounds));
			
			output.vesselProperties.Add("Infrastructure",new Infrastructure());
						
			output.vesselProperties.Add("Structure", new Structure());
			output.vesselProperties.Add("Hull", new Hull());
			
			output.vesselProperties.Add("Shield",new Shield()); //Only need shield if the right system is onboard
			

			
			return output;
		}
		
		public void addRoom(Room room, Vessel vessel)
		{
			List<Room> roomList = (List<Room>)vessel.vesselProperties["Rooms"];
			
			roomList.Add(room);
			
			vessel.vesselProperties.Remove("Rooms");
			vessel.vesselProperties.Add("Rooms", roomList);
		}
	}
}


