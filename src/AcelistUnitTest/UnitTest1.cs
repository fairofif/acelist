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

        public void TestMethodIdExistFalse()
        {
            bool status = false;
            if (receptionist.isIdExist("5544332211")) { status = true; }
            Assert.AreEqual(false, status);
        }

        public void ReturnNameFromIDButTrue()
        {
            bool status = false;
            if (receptionist.getNameFromId(receptionist.getArrEmployeeId()[1]) == "Monkey D. Luffy")
            {
                status = true;
            }
            Assert.AreEqual(true, status);
        }
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
}