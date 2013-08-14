using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;


namespace Madness_In_Space.JSON_Recepticles
{
	public class Vessel_Type_Data_From_JSON
	{
		public int  roomBudget;
		public string typeDescription;
		public int maxXBounds;
		public int maxYBounds;
		public int maxZBounds;
		public string[] requiredRooms;
		public string[] bannedRooms;
		public string type;
			
		public Vessel_Type_Data_From_JSON(string typeToGet)
		{
			//I admit temporary defeat JSON can be revisited after I do all the types in-line.
		}
	}
}
