using System;
using Acelist;
using Acelist.entities;

namespace AcelistUnitTest
{
    [TestClass]
    public class UnitTestBooking
    {
        Booking booking = new Booking();
        [TestMethod]
        public void TestReturnIDXFromBookId()
        {
            Assert.AreEqual(6, booking.findIdx(8));
        }
        [TestMethod]
        public void TestUpdateCheckin()
        {
            booking.updateHasCheckedin(2, true);
            Assert.AreEqual(true, booking.getArrHasCheckedIn()[booking.findIdx(2)]);
        }
        [TestMethod]
        public void TestUpdateUnCheckin()
        {
            booking.updateHasCheckedin(2, false);
            Assert.AreEqual(false, booking.getArrHasCheckedIn()[booking.findIdx(2)]);
        }
        [TestMethod]
        public void TestUpdateCheckout()
        {
            booking.updateHasCheckedout(2, true);
            Assert.AreEqual(true, booking.getArrHasCheckedOut()[booking.findIdx(2)]);
        }
        [TestMethod]
        public void TestUpdateUnCheckout()
        {
            booking.updateHasCheckedout(2, false);
            Assert.AreEqual(false, booking.getArrHasCheckedOut()[booking.findIdx(2)]);
        }
        [TestMethod]
        public void TestReturnRoomIDByBookID()
        {
            Assert.AreEqual(103, booking.getRoomIdByBookId(1));
        }
        [TestMethod]
        public void TestAddBooking()
        {
            int lenbookid = booking.getArrBookingID().Count;
            booking.addBooking("1122334455050", "55443322110002", "401", Convert.ToDateTime("2000/01/01"), Convert.ToDateTime("2000/01/02"), Convert.ToDateTime("2000/01/03"));
            int lenbookidafter = booking.getArrBookingID().Count;
            Assert.AreEqual(lenbookid + 1, lenbookidafter);
        }
        [TestMethod]
        public void TestDeleteBooking()
        {
            int lenbookid = booking.getArrBookingID().Count;
            booking.deleteBooking(booking.getArrBookingID()[(booking.getArrBookingID().Count) - 1]);
            int lenbookidafter = booking.getArrBookingID().Count;
            Assert.AreEqual(lenbookid - 1, lenbookidafter);
        }
        [TestMethod]
        public void TestFindCustomerIDTrue()
        {
            Assert.AreEqual(true, booking.isCustExist("1122334455001"));
        }
        [TestMethod]
        public void TestFindCustomerIDFalse()
        {
            Assert.AreEqual(false, booking.isCustExist("321"));
        }
    }
}