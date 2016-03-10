using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingProblem
{
    [TestClass]
    public class ShoppingProblem
    {
        [TestMethod]
        public void TestForTotalPrice()
        {
            var product = new Products[] { new Products(10, "Corn"), new Products(1010, "Samsung Smart TV"), new Products(3.5 , "Bread") };
            Assert.AreEqual(1023.5, CalculateTotalPrice(product));
        }

        [TestMethod]
        public void TestForCheapestProduct()
        {
            var product = new Products[] { new Products(31, "Beer"), new Products(30.30, "Book"), new Products(5.1, "Teddy Bear") };
            Assert.AreEqual("Teddy Bear", FindTheCheapestProduct(product));
        }

        [TestMethod]
        public void TestForExpensiveProduct()
        {
            var product = new Products[] { new Products(1600, "Bed"), new Products(100, "SDD"), new Products(150, "RAM") };
            Assert.AreEqual(0 , FindTheExpensiveProduct(product));
        }

        [TestMethod]
        public void TestForDeletedItem()
        {
            var product = new Products[] { new Products(1600, "Bed"), new Products(100, "SDD"), new Products(150, "RAM") };
            DeleteExpensiveProduct(product);
            Assert.IsTrue(product[0].productName != "Bed");
        }

        [TestMethod]
        public void TestForNewItem()
        {
            var product = new Products[] { new Products(1600, "Bed"), new Products(100, "SDD"), new Products(150, "RAM") };
            AddNewItem(ref product);
            Assert.IsTrue(product[product.Length-1].productName == "Mousepad");
        }

        struct Products
        {
            public double price;
            public string productName;

            public Products(double price, string productName)
            {
                this.price = price;
                this.productName = productName;
            }               
        }

        double CalculateTotalPrice(Products[] product)
        {
            double totalPrice = 0;
            for (int i = 0; i < product.Length; i++)
                totalPrice += product[i].price;
            return totalPrice;
        }

        string FindTheCheapestProduct(Products[] product)
        {
            double cheapestPrice = product[0].price;
            string cheapestProduct = product[0].productName;
            for (int i = 1; i < product.Length; i++)
                if (product[i].price < cheapestPrice)
                    cheapestProduct = product[i].productName;

            return cheapestProduct;
        }

        int FindTheExpensiveProduct(Products[] product)
        {
            double expensivePrice = product[0].price;
            int expensiveProduct = 0;
            for (int i = 1; i < product.Length; i++)
                if (product[i].price > expensivePrice)
                    expensiveProduct = i;

            return expensiveProduct;
        }

        void DeleteExpensiveProduct(Products[] product)
        {
            int deletedProduct = FindTheExpensiveProduct(product);
            product[deletedProduct] = product[product.Length - 1];
            Array.Resize(ref product, product.Length - 1);
        }

        void AddNewItem(ref Products[] product)
        {
            Array.Resize(ref product, product.Length + 1);
            product[product.Length - 1].price = 100;
            product[product.Length - 1].productName = "Mousepad";
        }
    }
}
