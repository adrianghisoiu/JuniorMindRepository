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
            Assert.AreEqual("You meet each other", CalculateIfWeMeetAgain(24));
        }

        string CalculateIfWeMeetAgain(int numberOfDays)
        {
            while (numberOfDays > 0)
            {
                if ((numberOfDays % 4) == 0 && (numberOfDays % 6 == 0))
                    return "You meet each other";
            }

            return Convert.ToString(numberOfDays);
        }
    }
}
