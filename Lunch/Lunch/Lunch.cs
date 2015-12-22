using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lunch
{
    [TestClass]
    public class Lunch
    {
        [TestMethod]
        public void OurFirstMeet()
        {
            Assert.AreEqual("You meet your friend again", CalculateIfWeMeetAgain(24));
        }

        [TestMethod]
        public void WeDontMeet()
        {
            Assert.AreEqual("You don't meet your friend", CalculateIfWeMeetAgain(20));
        }

        [TestMethod]
        public void TestWithWrongCondition()
        {
            Assert.AreEqual("Wrong condition", CalculateIfWeMeetAgain(-20));
        }

        string CalculateIfWeMeetAgain(int numberOfDays)
        {
            bool myCondition = (numberOfDays % 4) == 0 && (numberOfDays % 6 == 0);

            while (numberOfDays > 0)
            {
                if (myCondition)
                    return "You meet your friend again";
                else
                    return "You don't meet your friend";
            }

            return "Wrong condition";
        }
    }
}
