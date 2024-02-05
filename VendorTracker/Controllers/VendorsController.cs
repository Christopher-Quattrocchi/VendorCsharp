using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace Bakery.Controllers;

public class VendorsController : Controller
{
  [HttpGet("/vendors")]
  public ActionResult Index()
  {
    List<Vendor> allVendors = Vendor.GetAll();
    return View(allVendors);
  }
  [HttpGet("/vendors/new")]
  public ActionResult New()
  {
    return View();
  }

  [HttpPost("/vendors")]
  public ActionResult Create(string vendorName, string vendorDescription)
  {
    Vendor newVendor = new Vendor(vendorName, vendorDescription);
    return RedirectToAction("Index");
  }

  [HttpGet("/vendors/{id}")]
  public ActionResult Show(int id)
  {
    Vendor foundVendor = Vendor.Find(id);
    return View(foundVendor);
  }
}
