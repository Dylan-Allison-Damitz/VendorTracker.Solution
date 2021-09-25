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
      Vendor newVendor = new Vendor("test vendor", "test description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
        public void GetName_ReturnsName_String()
        {
          //Arrange
          string name = "Test Vendor";
          string description = "Test Description";
          Vendor newVendor = new Vendor(name, description);

          //Act
          string result = newVendor.Name;

          //Assert
          Assert.AreEqual(name, result);
        }

  }
}