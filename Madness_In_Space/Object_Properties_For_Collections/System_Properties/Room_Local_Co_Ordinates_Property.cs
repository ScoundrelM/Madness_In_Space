using System;

namespace Madness_In_Space
{
	public class Room_Local_Co_Ordinates_Property
	{
		public string ownerRoom;

		public float x;
		public float y;
		public float z;

		public float rotx;
		public float roty;
		public float rotz;

		public Room_Local_Co_Ordinates_Property (string owner, float xx, float yy, float zz, float rx, float ry, float rz)
		{
			this.ownerRoom = owner;

			this.x = xx;
			this.y = yy;
			this.z = zz;

			this.rotx = rx;
			this.roty = ry;
			this.rotz = rz;
		}
	}
}

