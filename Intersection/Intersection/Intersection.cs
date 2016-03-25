using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

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

        [TestMethod]
        public void TestForIntersectionPoint()
        {
            var directions = new Directions[] { Directions.Up, Directions.Down, Directions.Left, Directions.Right };
            var secondDirections = new Directions[] { Directions.Up, Directions.Up };
            Assert.AreEqual(true, FindIfCoordinatesIntersect(new Coordonates(2, 1), directions));
            Assert.AreEqual(false, FindIfCoordinatesIntersect(new Coordonates(3, 1), secondDirections));
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

        Coordonates CalculateNewCoordonates(Directions direction, Coordonates startCoordonates)
        {
            if (direction.Equals(Directions.Up))
                startCoordonates.y++;
            if (direction.Equals(Directions.Down))
                startCoordonates.y--;
            if (direction.Equals(Directions.Left))
                startCoordonates.x--;
            if (direction.Equals(Directions.Right))
                startCoordonates.x++;

            return startCoordonates;
        }

        bool FindIfCoordinatesIntersect(Coordonates startCoordonates, Directions[] directions)
        {
            Coordonates[] newCoordonates = new Coordonates[directions.Length + 1];
            Coordonates coordonates = new Coordonates();
            for (int i = 0; i < directions.Length; i++)
            {
                coordonates = CalculateNewCoordonates(directions[i], startCoordonates);
                if (Array.IndexOf(newCoordonates, coordonates) >= 0)
                    return true;
                else
                    newCoordonates[i] = coordonates;
            startCoordonates = coordonates;
            }
            return false;
        }
    }
}
