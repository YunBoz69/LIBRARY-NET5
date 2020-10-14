using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EcommerceWeb.Controllers
{
    public class UserController : Controller
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        public IActionResult Create()
        {
            if (Request.Method == "GET")
                return View();
            else if(Request.Method == "POST") {
                User user = new User
                {
                    FirstName = Request.Form["FirstName"],
                    LastName = Request.Form["LastName"],
                    IsAdmin = false,
                    Password = Request.Form["Password"],
                    Email = Request.Form["Email"]
                };

                User createdUser = _userService.Create(user);

                if (createdUser != null){

                    TempData["Message"] = "User " + createdUser.FirstName + " " + createdUser.LastName + " created.";

                    if (HttpContext.Session.GetInt32("isAdmin") == 1)
                        return RedirectToAction("Users", "User");
                    else 
                        return View("Signin");
                }
                else
                {
                    TempData["Message"] = "Error on account creation !";
                    return View();
                }

            }
            else
                return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Users()
        {
            if (HttpContext.Session.GetInt32("isAdmin") == 1)
                return View(_userService.GetAll());
            else
                return BadRequest();
        }


        public IActionResult Profile([FromRoute] int id)
        {
            User user = _userService.GetById(id);
            if (Request.Method == "GET")
                return View(_userService.GetById(id));
            else
                return View();
        }

        public IActionResult Edit([FromRoute] int id)
        {
            if (Request.Method == "GET")
            {
                if (HttpContext.Session.GetInt32("connectedUserId") == id)
                {
                    User user = _userService.GetById(id);
                    return View(user);
                }
                else
                {
                    TempData["Message"] = "400 : Bad Request !";
                    return BadRequest();
                }
            }
            else if (Request.Method == "POST")
            {
                User user = new User
                {
                    UserId = id,
                    FirstName = Request.Form["FirstName"],
                    LastName = Request.Form["LastName"],
                    IsAdmin = false,
                    Password = Request.Form["Password"],
                    Email = HttpContext.Session.GetString("connectedUser")
                };

                User editedUser = _userService.Update(user);

                if (editedUser != null)
                {

                    TempData["Message"] = "User " + editedUser.FirstName + " " + editedUser.LastName + " modified.";
                    return RedirectToAction("Profile", "User", new { id = editedUser.UserId });

                }
                else
                {
                    TempData["Message"] = "Error on edit profile !";
                    return RedirectToAction("Edit", "User");
                }

            }
            else
                return View();
        }

        public IActionResult SignOut()
        {
            HttpContext.Session.Remove("connectedUser");
            HttpContext.Session.Remove("connectedUserId");
            HttpContext.Session.Remove("isAdmin");
            return RedirectToAction("SignIn", "User");
        }


        public IActionResult Delete([FromRoute] int id)
        {
            if (Request.Method == "GET")
            {
                _userService.Delete(id);
                return RedirectToAction("Users", "User");
            }
            else
                return View();
        }


        public IActionResult Signin()
        {
            if (Request.Method == "GET")
            {
                if (HttpContext.Session.GetString("connectedUser") != null)
                    return RedirectToAction("Index", "Home");
                else
                    return View();
            }
            else if (Request.Method == "POST")
            {
                User user = new User
                {
                    Email = Request.Form["Email"],
                    Password = Request.Form["Password"]
                };

                User connectedUser = _userService.Connect(user.Email, user.Password);

                if (connectedUser != null)
                {
                    HttpContext.Session.SetInt32("connectedUserId", connectedUser.UserId);
                    HttpContext.Session.SetInt32("isAdmin", connectedUser.IsAdmin == true ? 1 : 0);
                    HttpContext.Session.SetString("connectedUser", connectedUser.Email);
                    HttpContext.Session.SetString("connectedUserName", connectedUser.FirstName);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["Message"] = "User not found, please register";
                    return View();
                }

            }
            else
                return View();
        }

    }

}