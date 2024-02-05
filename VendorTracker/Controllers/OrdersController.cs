using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace Bakery.Controllers;

public class OrdersController : Controller
{
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
        Vendor vendor = Vendor.Find(vendorId);
        return View(vendor);
    }

    [HttpPost("/orders")]
    public ActionResult Create(int vendorId, string orderTitle, string orderDescription, int orderPrice, DateTime orderDate)
    {
        Vendor foundVendor = Vendor.Find(vendorId);
        if (foundVendor != null)
        {
            Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
            foundVendor.AddOrder(newOrder);
        }
        return RedirectToAction("Show", "Vendors", new { id = vendorId });
    }
}