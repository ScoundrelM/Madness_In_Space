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
			Vessel output = new Vessel();
			
			output.vesselProperties.Add("Unique ID", vType + " " + ticker.issueNewID());
			output.vesselProperties.Add("Name",vesselName);
			output.vesselProperties.Add("Type",new Type_ID_Property("Vessel", vType));
			output.vesselProperties.Add("Rooms", new Hashtable()); //Fill hash table using the RoomFactory
			
			output.vesselProperties.Add("Bounds",new Bounding_Dimensions_Property(0,0,0));
			
			output.vesselProperties.Add("Infrastructure",new Infrastructure());
						
			output.vesselProperties.Add("Structure", new Structure());
			output.vesselProperties.Add("Hull", new Hull());
			
			output.vesselProperties.Add("Shield",new Shield()); //Only need shield is the right system is onboard
			
			output.vesselProperties.Add("Universal CoOrds",new Universal_Co_Ordinates_Property(vesselName,0,0,0,0,0,0));//This may possibly be better set by another part of the code.
			
			return output;
		}
	}
}


