using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Addresses.Models;
using System;

namespace Addresses.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        List<Address> allAddress = Address.GetAll();

        return View(allAddress);
      }

      [HttpPost("/make")]
      public ActionResult Make()
      {
        string newName = Request.Form["newName"];
        string newAddress = Request.Form["newAddress"];
        long newNumber = Convert.ToInt64(Request.Form["newNumber"]);
        Address newContact = new Address (newName, newAddress, newNumber);
        newContact.AddressSave();
        List<Address> allAddress = Address.GetAll();
        return View("Index", allAddress);
      }

      [HttpPost("/remove/{id}")]
      public ActionResult Remove(int id)
      {
        Address selectedAddress = Address.Find(id);
        selectedAddress.RemoveOne();
        List<Address> allAddress = Address.GetAll();
        return View("Index", allAddress);
      }

      [HttpPost("/clear")]
      public ActionResult Clear()
      {
        Address.ClearAll();
        List<Address> allAddress = Address.GetAll();
        return View("Index", allAddress);
      }
    }
}
