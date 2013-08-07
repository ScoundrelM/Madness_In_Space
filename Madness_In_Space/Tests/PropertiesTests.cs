using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections;

namespace Madness_In_Space
{
	[TestFixture()]
	public class PropertiesTests
	{

		[Test()]
		public void Type_id_should_be_a_keyvaluepair_of_two_strings()
		{
			Type_ID_Property testType = new Type_ID_Property ("Test Type", "Test Sub-Type");

			Assert.AreEqual (testType.typeData.Key, "Test Type");
			Assert.AreEqual (testType.typeData.Value, "Test Sub-Type");
		}

		[Test()]
		public void universal_coordinates_should_have_pointer_to_collection_owner_and_positions_and_rotations()
		{
			Universal_Co_Ordinates_Property testCoOrdinates = new Universal_Co_Ordinates_Property ("Test Vessel",1, 1, 1, 1, 1, 1);

			Assert.AreEqual (testCoOrdinates.x, 1 );
			Assert.AreEqual (testCoOrdinates.y, 1 );
			Assert.AreEqual (testCoOrdinates.z, 1 );
			Assert.AreEqual (testCoOrdinates.rotx, 1 );
			Assert.AreEqual (testCoOrdinates.roty, 1 );
			Assert.AreEqual (testCoOrdinates.rotz, 1 );
			Assert.AreEqual (testCoOrdinates.ownerVessel, "Test Vessel");

		}

		[Test()]
		public void ship_local_coordinates_should_have_pointer_to_collection_owner_and_positions_and_rotations()
		{
			Ship_Local_Co_Ordinates_Property testCoOrdinates = new Ship_Local_Co_Ordinates_Property ("Test Vessel", 1, 1, 1, 1, 1, 1);
			Assert.AreEqual (testCoOrdinates.x, 1 );
			Assert.AreEqual (testCoOrdinates.y, 1 );
			Assert.AreEqual (testCoOrdinates.z, 1 );
			Assert.AreEqual (testCoOrdinates.rotx, 1 );
			Assert.AreEqual (testCoOrdinates.roty, 1 );
			Assert.AreEqual (testCoOrdinates.rotz, 1 );
			Assert.AreEqual (testCoOrdinates.ownerVessel, "Test Vessel");

		}

		[Test()] 
		public void room_local_coordinates_should_have_pointer_to_collection_owner_and_positions_and_rotations()
		{
			Room_Local_Co_Ordinates_Property testCoOrdinates = new Room_Local_Co_Ordinates_Property ("Test Vessel", 1, 1, 1, 1, 1, 1);
			Assert.AreEqual (testCoOrdinates.x, 1 );
			Assert.AreEqual (testCoOrdinates.y, 1 );
			Assert.AreEqual (testCoOrdinates.z, 1 );
			Assert.AreEqual (testCoOrdinates.rotx, 1 );
			Assert.AreEqual (testCoOrdinates.roty, 1 );
			Assert.AreEqual (testCoOrdinates.rotz, 1 );
			Assert.AreEqual (testCoOrdinates.ownerRoom,"Test Vessel");
		}

		[Test()]
		public void a_room_should_be_a_hashtable_collection_of_its_properties()
		{
			Room testRoom = new Room (new Bounding_Dimensions_Property(1,1,1), new Ship_Local_Co_Ordinates_Property("Test Ship1",1,1,1,1,1,1), new Type_ID_Property("Test Type", "Test Sub-Type"));

			Assert.IsInstanceOf<Hashtable> (testRoom.room);
			Assert.IsInstanceOf<Bounding_Dimensions_Property>((Bounding_Dimensions_Property)testRoom.room["Bounds"]);
			Assert.IsInstanceOf<Ship_Local_Co_Ordinates_Property>((Ship_Local_Co_Ordinates_Property)testRoom.room["Ship Local CoOrdinates"]);
			Assert.IsInstanceOf<Type_ID_Property> ((Type_ID_Property)testRoom.room["Type"]);
			//Assert.IsInstanceOf<>(()testRoom.room[]);
 		}

		[Test]
		public void bounding_dimensions_should_have_width_length_and_height()
		{
			Bounding_Dimensions_Property testBounds = new Bounding_Dimensions_Property (1,1,1);
			Assert.AreEqual (testBounds.x,1);
			Assert.AreEqual (testBounds.y,1);
			Assert.AreEqual (testBounds.z,1);
		}
		
		[Test]
		public void UniqueID_should_increase_by_1_each_time_it_is_called()
		{
			Vessel_Factory testVFactory = new Vessel_Factory("Test Vessel");
			Unique_ID uID1 = new Unique_ID(testVFactory);
			Unique_ID uID2 = new Unique_ID(testVFactory);
			
			Assert.AreEqual(uID2.ID, uID1.ID + 1);
		}
		
	}
}
