using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cyclometter
{
    [TestClass]
    public class Cyclometter
    {
        [TestMethod]
        public void FindOneCyclistDistance()
        {
            var cyclist = new Cyclist[] { new Cyclist("George", new int[] { 5, 6, 4, 1 }, 6) };
            Assert.AreEqual(301.59, CalculateDistance(cyclist[0]), 1e-2);
        }

        [TestMethod]
        public void FindTotalDistance()
        {
            var cyclists = new Cyclist[] { new Cyclist("George", new int[] { 5, 6, 4, 1 }, 6), new Cyclist("Marian", new int[] { 1, 2, 1 }, 6) };
            Assert.AreEqual(377, CalculateTotalDistance(cyclists), 1e-2);
        }

        [TestMethod]
        public void FindMeanSpeedForOneCyclist()
        {
            var cyclist = new Cyclist[] { new Cyclist("George", new int[] { 1, 2, 1 }, 6) };
            Assert.AreEqual(25.13, CalculateMeanSpeedForOneCyclist(cyclist[0]), 1e-2);
        }

        [TestMethod]
        public void TestForCalculateMeanSpeed()
        {
            var cyclists = new Cyclist[] { new Cyclist("George", new int[] { 1, 2, 1 }, 6), new Cyclist("Bogdan", new int[] { 2, 2, 1 }, 6) };
            Assert.AreEqual(cyclists[1], CalculateMeanSpeed(cyclists));
        }

        [TestMethod]
        public void TestForCalculateMaximumSpeedPerSecond()
        {
            var cyclists = new Cyclist[] { new Cyclist("George", new int[] { 1, 3, 1 }, 6), new Cyclist("Bogdan", new int[] { 2, 2, 1 }, 6) };
            var second = 2;
            Assert.AreEqual("George", CalculateMaximumSpeedPerSecond(cyclists, out second));
        }

        struct Cyclist
        {
            public string nameOfCyclist;
            public int[] noOfRotations;
            public int diameter;

            public Cyclist(string nameOfCyclist, int[] noOfRotations, int diameter)
            {
                this.nameOfCyclist = nameOfCyclist;
                this.noOfRotations = noOfRotations;
                this.diameter = diameter;
            }
        }

        double CalculateDistance(Cyclist oneCyclist)
        {
            double circumference = Math.PI * oneCyclist.diameter;
            double distance = 0;
            for (int i = 0; i < oneCyclist.noOfRotations.Length; i++)
                distance += circumference * oneCyclist.noOfRotations[i];

            return distance;
        }

        double CalculateTotalDistance(Cyclist[] cyclist)
        {
            double totalDistance = 0;
            for (int i = 0; i < cyclist.Length; i++)
                totalDistance += CalculateDistance(cyclist[i]);

            return totalDistance;
        }

        double CalculateMeanSpeedForOneCyclist(Cyclist oneCyclist)
        {
            return CalculateDistance(oneCyclist) / oneCyclist.noOfRotations.Length; 
        }

        Cyclist CalculateMeanSpeed(Cyclist[] cyclist)
        {
            var firstCyclist = cyclist[0];
            for (int i = 0; i < cyclist.Length; i++)
                firstCyclist = CalculateMeanSpeedForOneCyclist(firstCyclist) > CalculateMeanSpeedForOneCyclist(cyclist[i]) ? firstCyclist : cyclist[i];

            return firstCyclist;
        }

        string CalculateMaximumSpeedPerSecond(Cyclist[] cyclist, out int second)
        {
            double maxSpeed = 0;
            double speed = 0;
            string name = null;
            second = 0;
            for (int i = 0; i < cyclist.Length; i++)
                for (int j = 0; j < cyclist[i].noOfRotations.Length; j++)
                {
                    speed = cyclist[i].noOfRotations[j] * Math.PI * cyclist[i].diameter;
                    if (speed > maxSpeed)
                    {
                        maxSpeed = speed;
                        name = cyclist[i].nameOfCyclist;
                        second = j+1;
                    }
                }

            return name;
        }
    }
}