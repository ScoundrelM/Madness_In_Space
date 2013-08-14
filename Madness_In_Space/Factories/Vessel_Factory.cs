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
			
			//allowed room list
			output.vesselProperties.Add("Rooms", new Hashtable()); //Fill hash table using the RoomFactory
			
			output.vesselProperties.Add("Bounds",new Bounding_Dimensions_Property(typeStats.maxXBounds,typeStats.maxYBounds,typeStats.maxZBounds));
			
			output.vesselProperties.Add("Infrastructure",new Infrastructure());
						
			output.vesselProperties.Add("Structure", new Structure());
			output.vesselProperties.Add("Hull", new Hull());
			
			output.vesselProperties.Add("Shield",new Shield()); //Only need shield is the right system is onboard
			

			
			return output;
		}
	}
}


