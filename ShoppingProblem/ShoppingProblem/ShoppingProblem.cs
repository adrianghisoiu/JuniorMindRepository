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
            string cheapestProduct = null;
            for (int i = 1; i < product.Length; i++)
                if (product[i].price < cheapestPrice)
                    cheapestProduct = product[i].productName;

            return cheapestProduct;
        }
    }
}
