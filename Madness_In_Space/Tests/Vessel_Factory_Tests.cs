using NUnit;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections;

namespace Madness_In_Space
{
	[TestFixture]
	public class Vessel_Factory_Tests
	{
		[Test]
		public void vessel_factory_should_have_a_unique_ID_ticker()
		{
			Vessel_Factory testVesselFactory = new Vessel_Factory("Test Factory");
			Assert.IsInstanceOf<IDTicker>(testVesselFactory.ticker);
		}
		
		[Test]
		public void vessel_factory_should_contain_the_name_of_the_ship_being_constructed()
		{
			Vessel_Factory testVesselFactory = new Vessel_Factory("Test Vessel");
			Assert.AreEqual(testVesselFactory.vesselName, "Test Vessel");

		}
		
		[Test]
		public void vessel_factory_should_have_a_method_that_outputs_a_vessel()
		{
			Vessel testVessel;
			Vessel_Factory testVesselFactory = new Vessel_Factory("Test Vessel");
			testVessel = testVesselFactory.createNewVessel("Test Type");
			
			Assert.IsInstanceOf<Vessel>(testVessel);
		}
	}
}
