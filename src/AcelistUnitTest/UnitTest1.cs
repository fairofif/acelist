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
    }

    [TestClass]
    public class UnitTestRoom
    {
        Room room = new Room();
        [TestMethod]
        public void checkNumberOfRoom()
        {
            Assert.AreEqual(120, room.getArrRoomId().Count);
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
    }
}