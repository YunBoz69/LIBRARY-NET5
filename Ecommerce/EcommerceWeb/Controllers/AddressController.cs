using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


namespace EcommerceWeb.Controllers
{
    public class AddressController : Controller
    {
        private readonly AddressService _addressService;

        public AddressController(AddressService addressService)
        {
            _addressService = addressService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            if (Request.Method == "POST")
            {
                _addressService.Create(new Address()
                {
                    User = new User() { UserId = (int)HttpContext.Session.GetInt32("connectedUserId") },
                    FirstName = Request.Form["FirstName"],
                    LastName = Request.Form["LastName"],
                    FirstAddress = Request.Form["FirstAddress"],
                    City = Request.Form["City"],
                    PostalCode = Request.Form["PostalCode"],
                    IsBill = Request.Form["typechoice"] == "bill" ? true : false,
                    IsDelivery = Request.Form["typechoice"] == "bill" ? false : true,
                }, (int)HttpContext.Session.GetInt32("connectedUserId"));

                return RedirectToAction("Profile", "User", new { id = (int)HttpContext.Session.GetInt32("connectedUserId") });
            }
            else
                return View();
        }

        public IActionResult Delete([FromRoute] int id)
        {
            if (Request.Method == "GET")
            {
                _addressService.Delete((int)HttpContext.Session.GetInt32("connectedUserId"), id);

                return RedirectToAction("Profile", "User", new { id = (int)HttpContext.Session.GetInt32("connectedUserId") });
            }
            else
                return View();
        }



    }
}