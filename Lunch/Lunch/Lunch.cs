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
            int x = hisNumber;
            int y = myNumber;
            //cmmdc
            while(hisNumber != myNumber )
            {
                if (hisNumber > myNumber)
                    hisNumber = hisNumber - myNumber;
                else
                    myNumber = myNumber - hisNumber;
            }
            //cmmmc
            return x * y / hisNumber;
        }
    }
}
