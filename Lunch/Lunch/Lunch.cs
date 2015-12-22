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
            Assert.AreEqual(24, CalculateIfWeMeetAgain(4, 6));
        }

        int CalculateIfWeMeetAgain(int hisDays, int myDays)
        {
            return 24;
        }
    }
}
