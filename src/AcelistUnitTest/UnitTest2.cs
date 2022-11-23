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
}