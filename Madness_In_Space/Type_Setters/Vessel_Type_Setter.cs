using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Madness_In_Space
{
	public class Vessel_Type_Setter
	{
		public string[] allRooms = new string[] {"Pod Cockpit","Pod Bay","Fighter Cockpit", "Shuttle Cockpit", "Bridge", "Medical Bay", "Engineering", "Comms", "Brig","Security","Cargo Hold","Cabin","Passenger Cabin","Dormitory","Mess","Engine Room","Hangar","Life Support","Cloning Facility","Security","Armoury","Airlock","Observation Deck","Science Lab","Agriculture Bay","Weapons Bay"};
		
		public int  roomBudget;
		public string typeDescription;
		public int maxXBounds;
		public int maxYBounds;
		public int maxZBounds;
		public string[] requiredRooms;
		public string[] bannedRooms;
		public string[] availableRooms;
		
		public string type;
		
		public Vessel_Type_Setter(string typeToSetTo)
		{
			switch (typeToSetTo)
			{
				case "Pod":
					
					this.roomBudget = 1;
					this.typeDescription = "A Pod is a single room vessel, usually but not solely used as an escape vessel on a larger vessel.";
					this.maxXBounds = 6;
					this.maxYBounds = 6;
					this.maxZBounds = 4;
					this.requiredRooms = new string[] {"Pod Cockpit"};
					
					this.bannedRooms = new string[] {"Fighter Cockpit", "Pod Bay","Shuttle Cockpit", "Bridge", "Medical Bay", "Engineering", "Comms", "Brig","Security","Cargo Hold","Cabin","Passenger Cabin","Dormitory","Mess","Engine Room","Hangar","Life Support","Cloning Facility","Security","Armoury","Airlock","Observation Deck","Science Lab","Agriculture Bay","Weapons Bay"};
					
					this.availableRooms = allRooms.Except(bannedRooms).ToArray();
					this.type = "Pod";
					
					break;
					
				case "Fighter":
					
					this.roomBudget = 1;
					this.typeDescription = "TBD";
					this.maxXBounds =1;
					this.maxYBounds = 4;
					this.maxZBounds = 2;
					this.requiredRooms = new string[] { "Fighter Cockpit"};
					this.bannedRooms = new string[] { "Shuttle Cockpit", "Bridge", "Medical Bay", "Engineering", "Comms", "Brig","Security","Cargo Hold","Cabin","Passenger Cabin","Dormitory","Mess","Engine Room","Hangar","Life Support","Cloning Facility","Security","Armoury","Airlock","Observation Deck","Science Lab","Agriculture Bay","Weapons Bay"};
					this.availableRooms = allRooms.Except(bannedRooms).ToArray();
					this.type = "Fighter";
					
					break;
					
				case "Shuttle":
					
					this.roomBudget = 3;
					this.typeDescription = "TBD";
					this.maxXBounds = 12;
					this.maxYBounds = 24;
					this.maxZBounds = 4;
					this.requiredRooms = new string[] { "Shuttle Cockpit"};
					this.bannedRooms = new string[] {"Fighter Cockpit", "Shuttle Cockpit", "Bridge", "Medical Bay", "Engineering", "Comms", "Brig","Security","Cargo Hold","Cabin","Passenger Cabin","Dormitory","Mess","Engine Room","Hangar","Life Support","Cloning Facility","Security","Armoury","Airlock","Observation Deck","Science Lab","Agriculture Bay","Weapons Bay"};
					this.availableRooms = allRooms.Except(bannedRooms).ToArray();
					this.type = "Shuttle";
					
					break;
					
				case "Frigate":
					
					this.roomBudget = 4;
					this.typeDescription = "TBD";
					this.maxXBounds = 20;
					this.maxYBounds = 50;
					this.maxZBounds = 8;
					this.requiredRooms = new string[] { "Bridge"};
					this.bannedRooms = new string[] {"Fighter Cockpit", "Shuttle Cockpit", "Bridge", "Medical Bay", "Engineering", "Comms", "Brig","Security","Cargo Hold","Cabin","Passenger Cabin","Dormitory","Mess","Engine Room","Hangar","Life Support","Cloning Facility","Security","Armoury","Airlock","Observation Deck","Science Lab","Agriculture Bay","Weapons Bay"};
					this.availableRooms = allRooms.Except(bannedRooms).ToArray();
					this.type = "Frigate";
					
					break;
					
				case "Cruiser":
					
					this.roomBudget = 5;
					this.typeDescription = "TBD";
					this.maxXBounds = 18;
					this.maxYBounds = 36;
					this.maxZBounds =12;
					this.requiredRooms = new string[] {"Bridge"};
					this.bannedRooms = new string[] {"Fighter Cockpit", "Shuttle Cockpit", "Bridge", "Medical Bay", "Engineering", "Comms", "Brig","Security","Cargo Hold","Cabin","Passenger Cabin","Dormitory","Mess","Engine Room","Hangar","Life Support","Cloning Facility","Security","Armoury","Airlock","Observation Deck","Science Lab","Agriculture Bay","Weapons Bay"};
					this.availableRooms = allRooms.Except(bannedRooms).ToArray();
					this.type = "Cruiser";
					
					break;
					
				case "Yacht":
					
					this.roomBudget = 6;
					this.typeDescription = "TBD";
					this.maxXBounds = 18;
					this.maxYBounds = 36;
					this.maxZBounds = 12;
					this.requiredRooms = new string[] {"Bridge" };
					this.bannedRooms = new string[] {"Pod Cockpit", "Fighter Cockpit", "Shuttle Cockpit", "Bridge", "Medical Bay", "Engineering", "Comms", "Brig","Security","Cargo Hold","Cabin","Passenger Cabin","Dormitory","Mess","Engine Room","Hangar","Life Support","Cloning Facility","Security","Armoury","Airlock","Observation Deck","Science Lab","Agriculture Bay","Weapons Bay"};
					this.availableRooms = allRooms.Except(bannedRooms).ToArray();
					this.type = "Yacht";
					
					break;
					
				case "Freighter":
					
					this.roomBudget = 7;
					this.typeDescription = "TBD";
					this.maxXBounds = 24;
					this.maxYBounds = 48;
					this.maxZBounds = 16;
					this.requiredRooms = new string[] { "Bridge"};
					this.bannedRooms = new string[] {"Fighter Cockpit", "Shuttle Cockpit", "Bridge", "Medical Bay", "Engineering", "Comms", "Brig","Security","Cargo Hold","Cabin","Passenger Cabin","Dormitory","Mess","Engine Room","Hangar","Life Support","Cloning Facility","Security","Armoury","Airlock","Observation Deck","Science Lab","Agriculture Bay","Weapons Bay"};
					this.availableRooms = allRooms.Except(bannedRooms).ToArray();
					this.type = "Freighter";
					
					break;
					
				case "Capital":
					
					this.roomBudget = 8;
					this.typeDescription = "TBD";
					this.maxXBounds = 24;
					this.maxYBounds = 72;
					this.maxZBounds = 20;
					this.requiredRooms = new string[] { "Bridge"};
					this.bannedRooms = new string[] {"Fighter Cockpit", "Shuttle Cockpit", "Bridge", "Medical Bay", "Engineering", "Comms", "Brig","Security","Cargo Hold","Cabin","Passenger Cabin","Dormitory","Mess","Engine Room","Hangar","Life Support","Cloning Facility","Security","Armoury","Airlock","Observation Deck","Science Lab","Agriculture Bay","Weapons Bay"};
					this.availableRooms = allRooms.Except(bannedRooms).ToArray();
					this.type = "Capital";
					
					break;
					
				case "Station":
					
					this.roomBudget = 9;
					this.typeDescription = "TBD";
					this.maxXBounds = 1000;
					this.maxYBounds = 1000;
					this.maxZBounds = 1000;
					this.requiredRooms = new string[] { "Bridge"};
					this.bannedRooms = new string[] {"Fighter Cockpit", "Shuttle Cockpit", "Bridge", "Medical Bay", "Engineering", "Comms", "Brig","Security","Cargo Hold","Cabin","Passenger Cabin","Dormitory","Mess","Engine Room","Hangar","Life Support","Cloning Facility","Security","Armoury","Airlock","Observation Deck","Science Lab","Agriculture Bay","Weapons Bay"};
					this.availableRooms = allRooms.Except(bannedRooms).ToArray();
					this.type = "Station";
					
					break;
					
				default:
					Console.WriteLine("Default case");
					break;
			}
		}
	}
}
