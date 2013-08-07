using System;

namespace Madness_In_Space
{
	public class Universal_Co_Ordinates_Property
	{
		public string ownerVessel;
		public float x;
		public float y;
		public float z;
		public float rotx;
		public float roty;
		public float rotz;

		public Universal_Co_Ordinates_Property (string owner, float xx, float yy, float zz, float rx, float ry, float rz)
		{
			this.ownerVessel = owner;

			this.x = xx;
			this.y = yy;
			this.z = zz;

			this.rotx = rx;
			this.roty = ry;
			this.rotz = rz;
		}
	}
}

