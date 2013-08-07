using System;
using System.Collections.Generic;

namespace Madness_In_Space
{
	public class Type_ID_Property
	{
		public KeyValuePair<string,string> typeData;

		public Type_ID_Property (string inKey, string inValue)
		{
			this.typeData = new KeyValuePair<string, string> (inKey, inValue);
		}
	}
}

