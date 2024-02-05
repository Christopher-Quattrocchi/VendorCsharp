using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Threading;

namespace Bakery.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void CheckVendorConstructor_CheckIfVendorConstructorCreatesInstance_Bool()
    {
      Vendor newVendor = new Vendor("Jim", "Loyal customer");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetNameOfVendor_ReturnVendorName_String()
    {
      string name = "Jim";
      Vendor newVendor = new Vendor(name, "Loyal customer");
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void SetNameOfVendor_SetVendorName_String()
    {
      string name = "Jim";
      Vendor newVendor = new Vendor(name, "Loyal customer");
      string crabName = "Crab King";
      newVendor.Name = crabName;
      string result = newVendor.Name;
      Assert.AreEqual(crabName, result);
    }
    [TestMethod]
    public void GetDescriptionOfVendor_GetVendorDescription_String()
    {
      string description = "Loyal customer";
      Vendor newVendor = new Vendor("Jim", description);
      string result = newVendor.Description;
      Assert.AreEqual(description, result);

    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      Vendor newVendor = new Vendor("Jim", "Test Vendor");
      List<Order> expectedList = new List<Order>();
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(expectedList, result);
    }
    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      // Arrange
      string title = "Weekly Croissants";
      string description = "Order for 30 croissants";
      int price = 45;
      DateTime date = DateTime.Now;
      Order newOrder = new Order(title, description, price, date);
      List<Order> newList = new List<Order> { newOrder };
      Vendor newVendor = new Vendor("Suzie's Cafe", "Cafe in downtown");

      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;

      CollectionAssert.AreEqual(newList, result);
    }
  }
}
