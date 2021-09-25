using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorsTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
        public void GetName_ReturnsName_String()
        {
          //Arrange
          string name = "Test Vendor";
          //string description = "Test Description";
          Vendor newVendor = new Vendor(name);

          //Act
          string result = newVendor.Name;

          //Assert
          Assert.AreEqual(name, result);
        }
    
    [TestMethod]
        public void GetId_ReturnsVendorId_Int()
        {
          //Arrange
          string name = "Test Vendor";
          //string description = "Test Description";
          Vendor newVendor = new Vendor(name);

          //Act
          int result = newVendor.Id;

          //Assert
          Assert.AreEqual(1, result);
        }

      [TestMethod]
        public void GetAll_ReturnsAllVendorObjects_VendorList()
        {
          //Arrange
          string name1 = "Pastry";
          string name2 = "dough";
          //string description1 = "Test description";
          //string description2 = "Test description 2";
          Vendor newVendor1 = new Vendor(name1);
          Vendor newVendor2 = new Vendor(name2);
          List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2};

          //Act
          List<Vendor> result = Vendor.GetAll();

          //Assert
          CollectionAssert.AreEqual(newList, result);
        }
      
      [TestMethod]
        public void Find_ReturnsCorrectVendor_Vendor()
        {
          //Arrange
          string name1 = "Pastry";
          string name2 = "Dough";
          // string description1 = "Test description";
          // string description2 = "Test description 2";
          Vendor newVendor1 = new Vendor(name1);
          Vendor newVendor2 = new Vendor(name2);

          //Act
          Vendor result = Vendor.Find(2);

          //Assert
          Assert.AreEqual(newVendor2, result);
        }

        [TestMethod]
        public void AddVendor_AssociatesVendorWithVendor_OrderList()
        {
          //Arrange
          string name = "Pastini";
          string description = "Italian Restaurant";
          string date = "February 23rd";
          string price = "$750";
          Order newOrder = new Order(name, description, date, price);
          List<Order> newList = new List<Order> { newOrder };
          string vendorName = "Bread";
          //string vendorDescription = "dough";
          Vendor newVendor = new Vendor(vendorName);
          newVendor.AddOrder(newOrder);

          //Act
          List<Order> result = newVendor.Orders;

          //Assert
          CollectionAssert.AreEqual(newList, result);
        }
  }
}