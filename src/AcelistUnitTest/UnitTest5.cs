using System;
using Acelist;
using Acelist.entities;

namespace AcelistUnitTest
{
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
}