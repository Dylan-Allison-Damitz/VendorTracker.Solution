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

        [TestMethod]
        public void GetOrderDescription_ReturnsOrderDescription_String()
        {
          string description = "Italian restaurant";
          Order newOrder = new Order("test", description, "test", "test");
          string result = newOrder.Description;
          Assert.AreEqual(description, result);
        }

        [TestMethod]
        public void SetDescription_SetDescription_String()
        {
          //Arrange
          string description = "Italian resaurant";
          Order newOrder = new Order("test", description, "test", "test");

          //Act
          string updatedDescription = "Vendor for Italian restaurant";
          newOrder.Description = updatedDescription;
          string result = newOrder.Description;

          //Assert
          Assert.AreEqual(updatedDescription, result);
        }

        [TestMethod]
        public void SetName_SetName_String()
        {
          //Arrange
          string name = "Vendor for Italian restaurant";
          Order newOrder = new Order(name, "test", "test", "test");

          //Act
          string updatedName = "Sells breadsticks";
          newOrder.Name = updatedName;
          string result = newOrder.Name;

          //Assert
          Assert.AreEqual(updatedName, result);
        }
    }