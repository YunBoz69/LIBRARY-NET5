using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using EcommerceWeb.Models;
using Microsoft.AspNetCore.Http;

namespace EcommerceWeb.Controllers
{
    public class HomeController : Controller
    {

        private readonly UserService _userService;
        private readonly ProductService _productService;

        public HomeController(UserService userService, ProductService productService)
        {
            _userService = userService;
            _productService = productService;
        }


        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("connectedUser") != null )
            {
                ViewData["last_products"] = _productService.GetProductsByRange(-1, 6);
                return View();
            }
            else
            {
                TempData["Message"] = "Please Sign In ! ";
                return RedirectToAction("Signin", "User"); ;
            }

        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
