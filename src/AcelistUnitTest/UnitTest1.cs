using System;
using Acelist;
using Acelist.entities;

namespace AcelistUnitTest
{
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