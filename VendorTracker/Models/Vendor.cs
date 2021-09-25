using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor 
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }
    
    
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}