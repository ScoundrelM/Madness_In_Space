using System;
using System.Collections.Generic;
using System.Collections;

namespace Madness_In_Space
{
	public class Room
	{
		public Hashtable roomProperties;

		public Room (Vessel_Factory vFactory)
		{
			roomProperties = new Hashtable ();
		}
	}
}