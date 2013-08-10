using System;
using System.Collections.Generic;
using System.Collections;

namespace Madness_In_Space
{
	public class Room
	{
		public Hashtable room;
		public int uniqueID;

		public Room (Vessel_Factory vFactory)
		{
			uniqueID = vFactory.ticker.issueNewID();
			room = new Hashtable ();
		}
		
	}
}

