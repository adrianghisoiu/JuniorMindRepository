using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ServiceRepair
{
    [TestClass]
    public class ServiceRepair
    {
        [TestMethod]
        public void ServiceSort()
        {
            var cars = new Car[] { new Car("Bmw", Priority.Low), new Car("Audi", Priority.Medium), new Car("Dacia", Priority.High) };
            var expect = new Car[] { new Car("Dacia", Priority.High), new Car("Audi", Priority.Medium), new Car("Bmw", Priority.Low) };
            CollectionAssert.AreEqual(expect, InsertionSort(cars));
        }

        public enum Priority
        {
            High = 1,
            Medium = 2,
            Low = 3
        }

        public struct Car
        {
            public string name;
            public Priority priority;

            public Car(string name, Priority priority)
            {
                this.name = name;
                this.priority = priority;
            }
        }

        Car[] InsertionSort(Car[] cars)
        {
            for (int i = 0; i < cars.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (cars[j-1].priority > cars[j].priority)
                    {
                        Swap(ref cars[j-1], ref cars[j]);
                    }
                }
            }
            return cars;
        }

        private static void Swap(ref Car first, ref Car second)
        {
            Car temp = first;
            first = second;
            second = temp;
        }
    }
}
