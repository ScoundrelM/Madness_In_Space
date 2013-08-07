using System;
using NUnit.Framework;
using System.Collections;

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

			Assert.IsInstanceOf<Type_ID_Property>((Type_ID_Property)testVessel.vesselProperties["Type"]);
		}
		
		[Test]
		public void vessel_should_have_rooms()
		{
			Vessel_Factory testVesselFactory = new Vessel_Factory("Test Vessel");
			Vessel testVessel = testVesselFactory.createNewVessel("Test Type");

			Assert.IsInstanceOf<Hashtable>((Hashtable)testVessel.vesselProperties["Rooms"]);
		}
		
		[Test]
		public void vessel_should_have_a_hull()
		{
			Vessel_Factory testVesselFactory = new Vessel_Factory("Test Vessel");
			Vessel testVessel = testVesselFactory.createNewVessel("Test Type");
			
			Assert.IsInstanceOf<Hull>((Hull)testVessel.vesselProperties["Hull"]);
		}
		
		[Test]
		public void vessel_should_have_a_structure()
		{
			Vessel_Factory testVesselFactory = new Vessel_Factory("Test Vessel");
			Vessel testVessel = testVesselFactory.createNewVessel("Test Type");
			
			Assert.IsInstanceOf<Structure>((Structure)testVessel.vesselProperties["Structure"]);
		}
		
		[Test]
		public void vessel_should_have_an_infrastructure()
		{
			Vessel_Factory testVesselFactory = new Vessel_Factory("Test Vessel");
			Vessel testVessel = testVesselFactory.createNewVessel("Test Type");
			
			Assert.IsInstanceOf<Infrastructure>((Infrastructure)testVessel.vesselProperties["Infrastructure"]);
		}
		
		[Test]
		public void vessel_should_have_a_shield()
		{
			Vessel_Factory testVesselFactory = new Vessel_Factory("Test Vessel");
			Vessel testVessel = testVesselFactory.createNewVessel("Test Type");
			
			Assert.IsInstanceOf<Shield>((Shield)testVessel.vesselProperties["Shield"]);
		}
	}
}