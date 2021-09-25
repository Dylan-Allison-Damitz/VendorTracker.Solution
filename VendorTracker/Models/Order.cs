using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order 
  {
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}