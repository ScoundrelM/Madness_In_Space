using System;

namespace Madness_In_Space
{
	/// <summary>
	/// Description of Unique_ID.
	/// </summary>
	public class Unique_ID
	{
		public string shipID;
		public int ID;
		
		public Unique_ID(Vessel_Factory vFactory)
		{
			 this.shipID = vFactory.vesselName;
			 this.ID = vFactory.ticker.issueNewID();
		}
	}
}
