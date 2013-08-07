using System;
using System.Collections.Generic;
using System.Collections;

namespace Madness_In_Space
{
	public class Room
	{
		public Hashtable room;

		public Room (Bounding_Dimensions_Property bounds, Ship_Local_Co_Ordinates_Property sCoOrd, Type_ID_Property type )
		{
			room = new Hashtable ();
			room.Add ("Bounds", bounds );
			room.Add ("Ship Local CoOrdinates", sCoOrd);
			room.Add ("Type", type);

		}
		
	}
}

