using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HanoiTowers
{
    [TestClass]
    public class HanoiTowers
    {
        [TestMethod]
        public void MovingThreeDisks()
        {
            int[] source = new int[] { 4, 2, 1 };
            int[] destination = new int[source.Length];
            int[] auxiliar = new int[source.Length];
            CollectionAssert.AreEqual(source, MoveTowers(3, source, destination, auxiliar));
        }


        int[] MoveTowers(int disk, int[] source, int[] destination, int[] auxiliar)
        {
            if (disk == 0)
            {
                destination[disk] = source[disk];
                Resize(source);
                return destination;
            }
            MoveTowers(disk - 1, source, auxiliar, destination);
            destination[disk-1] = source[disk-1];
            Resize(source);
            MoveTowers(disk - 1, auxiliar, destination, source);
            return destination;
        }

        private static int[] Resize(int[] source)
        {
            Array.Resize(ref source, source.Length - 1);
            return source;
        }
    }
}
