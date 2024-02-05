using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Threading;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("title", "description", 10, DateTime.Now);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetProperties_ReturnsProperties_PropertyValues()
    {
      string title = "Birthday Cake";
      string description = "Chocolate cake for birthday";
      int price = 50;
      DateTime date = DateTime.Now;
      Order newOrder = new Order(title, description, price, date);

      Assert.AreEqual(title, newOrder.Title);
      Assert.AreEqual(description, newOrder.Description);
      Assert.AreEqual(price, newOrder.Price);
      Assert.AreEqual(date, newOrder.Date);
    }

    [TestMethod]
    public void SetProperties_SetsProperties_PropertyValues()
    {
      Order newOrder = new Order("title", "description", 10, DateTime.Now);

      newOrder.Title = "Updated Title";
      newOrder.Description = "Updated Description";
      newOrder.Price = 20;
      DateTime newDate = DateTime.Now.AddDays(1);
      newOrder.Date = newDate;

      Assert.AreEqual("Updated Title", newOrder.Title);
      Assert.AreEqual("Updated Description", newOrder.Description);
      Assert.AreEqual(20, newOrder.Price);
      Assert.AreEqual(newDate, newOrder.Date);
    }
  }
}