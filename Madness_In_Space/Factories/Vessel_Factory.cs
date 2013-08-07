/*
 * Created by SharpDevelop.
 * User: bch00232
 * Date: 05/08/2013
 * Time: 12:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Madness_In_Space
{
	/// <summary>
	/// Description of Vessel_Factory.
	/// </summary>
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

			output.vesselProperties.Add("Name",vesselName);
			output.vesselProperties.Add("Type",new Type_ID_Property("Vessel", vType));
			output.vesselProperties.Add("Bounds",new Bounding_Dimensions_Property(0,0,0));
			output.vesselProperties.Add("Universal CoOrds",new Universal_Co_Ordinates_Property(vesselName,0,0,0,0,0,0));
			//output.vesselProperties.Add("",);
			
			return output;
		}
	}
}
