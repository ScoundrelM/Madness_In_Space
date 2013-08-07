using System;

namespace Madness_In_Space
{
	public class IDTicker
	{
		public int ticker;
		public IDTicker()
		{
			this.ticker = 0;
		}
		
		public int issueNewID()
		{
			ticker++;
			return ticker;
						
		}
	}
}
		
		
	

