using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor 
  {
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}