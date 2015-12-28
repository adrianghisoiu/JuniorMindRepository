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
            Assert.AreEqual(12, CalculateIfWeMeetAgain(4, 6));
        }


        int CalculateIfWeMeetAgain(int hisNumber, int myNumber)
        {

            int cmmdc = CalculateBiggestCommonDivisor(hisNumber, myNumber);
            return hisNumber * myNumber / cmmdc;
        }

        int CalculateBiggestCommonDivisor(int hisNumber, int myNumber)
        {
            while (hisNumber != myNumber)
            {
                if (hisNumber > myNumber)
                    hisNumber = hisNumber - myNumber;
                else
                    myNumber = myNumber - hisNumber;
            }
            return hisNumber;
        }
    }
}
