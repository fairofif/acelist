using System;
using Acelist;
using Acelist.entities;

namespace AcelistUnitTest
{
    [TestClass]
    public class UnitTestDateNightBook
    {
        Booking booking = new Booking();
        [TestMethod]
        public void TestCountNightByID1()
        {
            DateNightBook dnb = new DateNightBook(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            Assert.AreEqual(7, dnb.countNightById(6));
        }
        [TestMethod]
        public void TestCountNightByID2()
        {
            DateNightBook dnb = new DateNightBook(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            Assert.AreEqual(1, dnb.countNightById(8));
        }
    }
}