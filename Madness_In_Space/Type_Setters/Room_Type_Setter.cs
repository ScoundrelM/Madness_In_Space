
using System;

namespace Madness_In_Space
{
	/// <summary>
	/// Description of Room_Type_Setter.
	/// </summary>
	public class Room_Type_Setter
	{
		public int maxXBounds;
		public int maxYBounds;
		public int maxZBounds;
		
		public int minXBounds;
		public int minYBounds;
		public int minZBounds;
		
		public string[] allSystems  = new string[] {"Generator","Engine","Capacitor","Pilot Controls","AI","Shield Generator","Power Generator","Fabricator","Waste Disposal","Fuel Store","Air Scrubber","Air Pump","Temperature Control","Gravity Generator","Transmitter","Receiver","Cryptography","Weapons Targeting","Weapons Firing","Surgery Table","Hangar","Repair Bay","Power Distributor"};
		public string[] requiredSystems;
		public string[] bannedSystems;
		public string[] availableSystems;
				
		public string[] allInterfaces = new string[] {"Gravity Panel", "Power","Air Vent","Comms Point", "Waste Disposal"};
		public string[] requiredInterfaces;
		public string[] bannedInterfaces;
		public string[] availableInterfaces;
		
		public Room_Type_Setter(string typeToSetTo)
		{
			switch(typeToSetTo)
			{
				case "Pod Cockpit":
					
					break;

				case "Pod Bay":
					
					break;
					
				case "Fighter Cockpit":
					
					break;
					
				case "Bridge":
					
					break;
					
				case "Medical Bay":
					
					break;
					
				case "Engineering":
					
					break;
					
				case "Comms":
					
					break;
					
				case "Brig":
					
					break;

					
				case "Cargo Hold":
					
					break;
					
				case "Cabin":
					
					break;
					
				case "Passenger Cabin":
					
					break;
					
				case "Dormitory":
					
					break;
					
				case "Mess":
					
					break;
					
				case "Engine Room":
					
					break;
					
				case "Hangar":
					
					break;
					
				case "Life Support":
					
					break;

				case "Cloning Facility":
					
					break;

				case "Security":
					
					break;

				case "Armoury":
					
					break;

				case "Airlock":
					
					break;

				case "Observation Deck":
					
					break;
					
				case "Science Lab":
					
					break;
					
				case "Agriculture Bay":
					
					break;
					
				case "Weapons Bay":
					
					break;
					
				default:
					
					break;
			}
		}
	}
}