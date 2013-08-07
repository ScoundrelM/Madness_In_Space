
using System;
using NUnit.Framework;

namespace Madness_In_Space.Tests
{
	[TestFixture]
	public class Room_Tests
	{
		[Test]
		public void rooms_should_have_a_unique_ID_as_their_key_in_the_Rooms_hashtable_in_a_vessel()
		{
			Vessel_Factory testVesselFactory = new Vessel_Factory("Test Vessel");
			Vessel testVessel = testVesselFactory.createNewVessel("Test Type");
			
			//Assert.AreEqual();
		}
	}
}
