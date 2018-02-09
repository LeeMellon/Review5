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

      [HttpPost("/makeNew")]
      public ActionResult MakeNewContact()
      {
        string newName = Request.Form["newName"];
        string newAddress = Request.Form["newAddress"];
        long newNumber = Convert.ToInt64(Request.Form["newNumber"]);
        Address newContact = new Address (newName, newAddress, newNumber);
        newContact.AddressSave();
        List<Address> allAddress = Address.GetAll();
        return View("Index", allAddress);
      }


    }
}
