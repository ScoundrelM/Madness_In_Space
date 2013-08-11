using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

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
			//JObject dataIn = JObject.Parse(@"X:\CODEZ\Madness_In_Space\Madness_In_Space\JSON_Type_Templates\Vessel_Types.json");
			
			using (StreamReader reader = File.OpenText(@"c:\person.json"))
			{
				JObject o = (JObject)JToken.ReadFrom(new JsonTextReader(reader));
				// do stuff
			}
			
		}
	}
}
