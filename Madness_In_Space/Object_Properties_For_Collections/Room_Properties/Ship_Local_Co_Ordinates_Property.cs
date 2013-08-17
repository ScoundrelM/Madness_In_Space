using System;

namespace Madness_In_Space
{
	public class Ship_Local_Co_Ordinates_Property
	{
		public string ownerVessel;
		public float x;
		public float y;
		public float z;

		public Ship_Local_Co_Ordinates_Property (string ship, float xx, float yy, float zz)
		{
			this.ownerVessel = ship;

			this.x = xx;
			this.y = yy;
			this.z = zz;

		}
	}
}

