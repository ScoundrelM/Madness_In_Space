
using System;
using NUnit.Framework;

namespace Madness_In_Space.Tests
{
	[TestFixture]
	public class Vessel_Tests
	{
		[Test]
		public void vessel_should_have_a_name()
		{
			Vessel_Factory testVesselFactory = new Vessel_Factory("Test Vessel");
			Vessel testVessel = testVesselFactory.createNewVessel("Test Type");
			
			Assert.AreEqual("Test Vessel", (string)testVessel.vesselProperties["Name"]);			
		}
		
		[Test]
		public void vessel_should_have_a_type()
		{
			Vessel_Factory testVesselFactory = new Vessel_Factory("Test Vessel");
			Vessel testVessel = testVesselFactory.createNewVessel("Test Type");
			
			Assert.AreEqual("Test Type", (Type_ID_Property)testVessel.vesselProperties["Type"]);
		}
	}
}
