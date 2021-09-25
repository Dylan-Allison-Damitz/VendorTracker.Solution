using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrdersTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

  }
}