using System;
using Acelist;
using Acelist.entities;

namespace AcelistUnitTest
{
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
}