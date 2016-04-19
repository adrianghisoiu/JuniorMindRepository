using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PavementForMarket
{
    [TestClass]
    public class PavementProblem
    {
        [TestMethod]
        public void FirstTestForExample()
        {
            int rocks = Pavement(6, 6, 4);
            Assert.AreEqual(4, rocks);
        }
        [TestMethod]
        public void SecondTestForMyValues()
        {
            int rocks = Pavement(10, 6, 4);
            Assert.AreEqual(6, rocks);
        }
    
        int Pavement(int mLength, int nWidth, int a)
        {
            int rocksPerLenght = (mLength / a);
            int rocksPerWidth = (nWidth / a);
       
            if ((mLength%a) != 0 )
            {
                rocksPerLenght += 1 ;
            }

            if((nWidth%a) != 0)
            {
                rocksPerWidth += 1;
            }

            return rocksPerLenght * rocksPerWidth;
        }
    }
}
