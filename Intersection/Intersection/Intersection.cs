using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Intersection
{
    [TestClass]
    public class Intersection
    {
        [TestMethod]
        public void TestForCalculateNewCoordonates()
        {
            var point = new Coordonates(2, 2);
            Assert.AreEqual(point, CalculateNewCoordonates(Directions.Up, new Coordonates(2, 1)));
        }

        enum Directions
        {
            Up = 1,
            Down,
            Left,
            Right
        }

        struct Coordonates
        {
            public int x;
            public int y;

            public Coordonates(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        Coordonates CalculateNewCoordonates(Directions directions, Coordonates startCoordonates)
        {
            if (directions.Equals(Directions.Up))
                startCoordonates.y++;
            if (directions.Equals(Directions.Down))
                startCoordonates.y--;
            if (directions.Equals(Directions.Left))
                startCoordonates.x--;
            if (directions.Equals(Directions.Right))
                startCoordonates.x++;

            return startCoordonates;
        }
    }
}
