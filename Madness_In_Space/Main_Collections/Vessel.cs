using System.Collections.Generic;
using System.Collections;
using System;

namespace Madness_In_Space
{
	/// <summary>
	/// The Vessel collection holds all of a ship's properties in a hash table.
	/// 
	/// </summary>
	public class Vessel
	{
		public Hashtable vesselProperties;
		
		public Vessel()
		{
			this.vesselProperties = new Hashtable();
		}
	}
}
