using System;
using Acelist;
using Acelist.entities;

namespace AcelistUnitTest
{
    [TestClass]
    public class UnitTestReceptionist
    {
        Receptionist receptionist = new Receptionist();
        [TestMethod]
        public void TestMethodIdExistTrue()
        {
            bool status = false;
            if (receptionist.isIdExist("55443322110001")) { status = true; }
            Assert.AreEqual(true, status);
        }

        [TestMethod]
        public void TestMethodIdExistFalse()
        {
            bool status = false;
            if (receptionist.isIdExist("5544332211")) { status = true; }
            Assert.AreEqual(false, status);
        }

        [TestMethod]
        public void ReturnNameFromIDButTrue()
        {
            bool status = false;
            if (receptionist.getNameFromId("55443322110002") == "Monkey D. Luffy")
            {
                status = true;
            }
            Assert.AreEqual(true, status);
        }

        [TestMethod]
        public void ReturnNameFromIDButFalse()
        {
            bool status = false;
            if (receptionist.getNameFromId(receptionist.getArrEmployeeId()[2]) == "Monkey D. Luffy")
            {
                status = true;
            }
            Assert.AreEqual(false, status);
        }

        [TestMethod]
        public void TestLoginTrue()
        {
            Assert.AreEqual(true, receptionist.checkLogin("nasikorea", "nasikorea"));
        }
        [TestMethod]
        public void TestLoginFalse()
        {
            Assert.AreEqual(false, receptionist.checkLogin("nasikorea", "123"));
        }
        [TestMethod]
        public void TestExistanceUsernameTrue()
        {
            Assert.AreEqual(true, receptionist.isUsernameExist("nasikorea"));
        }
        [TestMethod]
        public void TestExistanceUsernameFalse()
        {
            Assert.AreEqual(false, receptionist.isUsernameExist("koreanasi"));
        }
        [TestMethod]
        public void TestIdxUsername1()
        {
            Assert.AreEqual(1, receptionist.idxUsername("nasijepang"));
        }
        [TestMethod]
        public void TestIdxUsername2()
        {
            Assert.AreEqual(2, receptionist.idxUsername("nasibelanda"));
        }
    }

    [TestClass]
    public class UnitTestRoom
    {
        Room room = new Room();
        [TestMethod]
        public void CheckNumberOfRoom()
        {
            Assert.AreEqual(120, room.getArrRoomId().Count);
        }

        [TestMethod]
        public void TestPriceRoom1()
        {
            Assert.AreEqual(670000, room.getPriceByRoomId(106));
        }

        [TestMethod]
        public void TestPriceRoom2()
        {
            Assert.AreEqual(1150000, room.getPriceByRoomId(411));
        }

        [TestMethod]
        public void TestGetTypeRoom1()
        {
            Assert.AreEqual("Emperor", room.getTypeByRoomId(330));
        }
        [TestMethod]
        public void TestGetTypeRoom2()
        {
            Assert.AreEqual("Minister", room.getTypeByRoomId(120));
        }
    }

    [TestClass]
    public class UnitTestCustomer
    {
        Customer customer = new Customer();
        [TestMethod]
        public void TestCustomerIDIsExistTrue()
        {
            Assert.AreEqual(true, customer.isIdExist("1122334455007"));
        }
        [TestMethod]
        public void TestCustomerIDIsExistFalse()
        {
            Assert.AreEqual(false, customer.isIdExist("1234"));
        }

        [TestMethod]
        public void TestAddCustomer()
        {
            customer.addCustomer("123", "unittest", "unittest", "111-111-1111");
            Assert.AreEqual(true, customer.isIdExist("123"));
        }

        [TestMethod]
        public void TestDeleteCustomer()
        {
            customer.deleteCust("123");
            Assert.AreEqual(false, customer.isIdExist("123"));
        }
        [TestMethod]
        public void TestReturnNameByID()
        {
            Assert.AreEqual("Catarina Bullon", customer.getNameFromId("1122334455023"));
        }
    }

    [TestClass]
    public class UnitTestMenu
    {
        Menu menus = new Menu();
        [TestMethod]
        public void TestReturnNameFromID()
        {
            Assert.AreEqual("massage", menus.getNameFromItemId(1));
        }
        [TestMethod]
        public void TestReturnPriceFromID()
        {
            Assert.AreEqual(420000, menus.getPriceFromItemId(2));
        }
        [TestMethod]
        public void TestReturnIDFromName()
        {
            Assert.AreEqual(2, menus.getItemIdFromItemName("spa"));
        }
    }

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
            Assert.AreEqual(lenbookid-1, lenbookidafter);
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

    [TestClass]
    public class UnitTestDateNightBook
    {
        Booking booking = new Booking();
        [TestMethod]
        public void TestCountNightByID1()
        {
            DateNightBook dnb = new DateNightBook(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            Assert.AreEqual(7 ,dnb.countNightById(6));
        }
        [TestMethod]
        public void TestCountNightByID2()
        {
            DateNightBook dnb = new DateNightBook(booking.getArrBookingID(), booking.getArrRoomID(), booking.getArrCheckinTime(), booking.getArrCheckoutTime());
            Assert.AreEqual(1, dnb.countNightById(8));
        }
    }

    [TestClass]
    public class UnitTestOrders
    {
        Order orders = new Order();
        [TestMethod]
        public void TestIsIDHasOrderTrue()
        {
            Assert.AreEqual(true, orders.isHasOrder(1));
        }
        [TestMethod]
        public void TestIsIDHasOrderFalse()
        {
            Assert.AreEqual(false, orders.isHasOrder(8));
        }
        [TestMethod]
        public void TestAddOrder()
        {
            int lenArrayBefore = orders.getArrIdx().Count;
            orders.addOrder(1, 1, 1);
            int lenArrayAfter = orders.getArrIdx().Count;
            Assert.AreEqual(lenArrayBefore + 1, lenArrayAfter);
        }
        [TestMethod]
        public void TestDeleteOrder()
        {
            int lenArrayBefore = orders.getArrIdx().Count;
            orders.deleteOrder(orders.getArrIdx()[(orders.getArrIdx().Count)-1]);
            int lenArrayAfter = orders.getArrIdx().Count;
            Assert.AreEqual(lenArrayBefore - 1, lenArrayAfter);
        }
    }
}