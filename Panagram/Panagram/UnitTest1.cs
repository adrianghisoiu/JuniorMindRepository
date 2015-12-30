using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Panagram
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForPanagram()
        {
            Assert.AreEqual("Yes", SeeIfItsAPanagrams("abcdefghijklmnopqrstuvwxyz"));
        }

        string SeeIfItsAPanagrams(string myString)
        {
            int contor = 1;
            bool check = true;
            for (int i = 0; i < (myString.Length-1); i++)
            {
                for (int j = i + 1; j < myString.Length; j++)
                    if (myString[i] == myString[j])
                        check = false;
                if (check == true)
                    contor++;
            }
            if (contor == 26)
                return "Yes";
            else
                return "No";
        }
    }
}
