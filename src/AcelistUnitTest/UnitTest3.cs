using System;
using Acelist;
using Acelist.entities;

namespace AcelistUnitTest
{
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
}