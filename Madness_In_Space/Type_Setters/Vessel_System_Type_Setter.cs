using System;

namespace Madness_In_Space
{
	public class Vessel_System_Type_Setter
	{
		//These attributes are not defined by system  type.
		public Activated_Or_Deactivated_Property activatedBool = new Activated_Or_Deactivated_Property();
		public On_Or_Off_Property turnedOn;
		
		
		//These attributes are determined by type.
		public Activation_Power_Consumption_Property activationPowerConsumption;
		public Maintain_Activation_Power_Consumption_Property maintainActivationPowerConsumption;
		public Maintain_On_Power_Consumption_Property maintainOnPowerConsumption;
		public Power_Capacity_Property powerCapacity;
		
		public Vessel_System_Type_Setter(string typeToSetTo)
		{
			
			switch(typeToSetTo)
			{
				case "Air Pump":
					break;
					
				case "Gravity Generator":
					break;
					
				case "Temperature Control":
					break;
					
				case "Transmitter":
					break;
					
				case "Receiver":
					break;
					
				case "Cryptography":
					break;
					
				case "Weapons Targeting":
					break;
					
				case "Weapons Firing":
					break;
					
				case "Surgery Table":
					break;
					
				case "Hangar":
					break;
					
				case "Repair Bay":
					break;
					
				case "Power Distributor":
					break;
					
				case "Air Scrubber":
					break;
					
				case "Fuel Store":
					break;
					
				case "Waste Disposal":
					break;
					
				case "Fabricator":
					break;
					
				case "Power Generator":
					break;
					
				case "Shield Generator":
					break;
					
				case "AI":
					break;
					
				case "Pilot Controls":
					break;
					
				case "Capacitor":
					break;
					
				case "Engine":
					break;
					
				default:
					break;
			}
		}
	}
}

