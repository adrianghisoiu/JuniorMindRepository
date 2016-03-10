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
    }
}
