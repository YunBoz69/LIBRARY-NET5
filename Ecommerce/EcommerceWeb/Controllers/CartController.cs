using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EcommerceWeb.Controllers
{
    public class CartController : Controller
    {
        private readonly CartService _cartService;
        private readonly UserService _userService;

        public CartController(CartService cartService, UserService userService)
        {
            _cartService = cartService;
            _userService = userService;
        }
        public IActionResult Index([FromRoute] int id)
        {
            return View(_cartService.GetCartProducts(id));
        }

        public IActionResult List([FromRoute] int id)
        {
            return View(_cartService.GetCartsByUser(id));
        }

        public IActionResult Details([FromRoute] int id)
        {
            Cart cart = _cartService.GetCart(id);
            ViewData["cartId"] = cart.CartId;
            if (cart == null)
                return NotFound();
            return View(cart);
        }

        public IActionResult Thanks([FromRoute] int id)
        {

            string referer = Request.Headers["Referer"].ToString();
            if (referer.Contains("/Cart/Order"))
            {
                Cart cart = _cartService.GetCart(id);
                JObject jObject = JsonConvert.DeserializeObject<JObject>(cart.OrderInfo);
                ViewData["OrderInfo"] = jObject;
                ViewData["cartId"] = cart.CartId;
                return View(cart);
            }
            else
                return RedirectToAction("Index", "Home");
        }

        public IActionResult Order([FromRoute] int id)
        {

            if (Request.Method == "POST")
            {
                Object o = JsonConvert.DeserializeObject<Object>(Request.Form["json"]);
                Cart cart = _cartService.GetCartProducts(id);
                return RedirectToAction("Thanks", "Cart", new { id = _cartService.Order(id, o).CartId });
            }
            else
            {
                Cart cart = _cartService.GetCartProducts(id);
                ViewData["user"] = _userService.GetById((int)HttpContext.Session.GetInt32("connectedUserId"));
                return View(cart);
            }
        }


        public IActionResult AddProduct([FromRoute] int id)
        {
            int userId = (int) HttpContext.Session.GetInt32("connectedUserId");
            Cart cart = _cartService.AddProductToCart(id, userId);
            return RedirectToAction("Index", "Cart", new { id = userId });
        }

        public IActionResult RemoveProduct([FromRoute] int id)
        {
            int userId = (int) HttpContext.Session.GetInt32("connectedUserId");
            Cart cart = _cartService.RemoveProductToCart(id, userId);
            return RedirectToAction("Index", "Cart", new { id = userId });
        }

    }
}