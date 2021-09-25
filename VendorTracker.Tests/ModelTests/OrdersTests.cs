using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

[TestClass]
    public class OrderTests : IDisposable 
    {
        public void Dispose()
        {
            Order.ClearAll();
        }

        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
          Order newOrder = new Order("test", "test", "test", "test");
          Assert.AreEqual(typeof(Order), newOrder.GetType());
        }

        [TestMethod]
        public void GetOrderName_ReturnsOrderName_String()
        {
            string name = "Pastini";
            Order newOrder = new Order(name, "test", "test", "test");
            string result = newOrder.Name;
            Assert.AreEqual(name, result);
        }
    }