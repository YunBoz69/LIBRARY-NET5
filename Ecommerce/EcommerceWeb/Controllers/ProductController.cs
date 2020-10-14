using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Web.Helpers;
using EcommerceWeb.Utils;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace EcommerceWeb.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;
        private IHostingEnvironment _env;

        public ProductController(ProductService productService, IHostingEnvironment env)
        {
            _productService = productService;
            _env = env;
        }

        public IActionResult Products([FromQuery] int skip, [FromQuery] int nb, [FromQuery] string category, [FromQuery] double price)
        {
            List<Product> products = new List<Product>();
            foreach (string str in _productService.GetCategories())
                products.Add(new Product() { Category = str });
            ViewData["categories"] = products;
            ViewData["skip"] = skip;
            ViewData["nb"] = nb;
            if (skip > 0 && nb > 0)
                return View(_productService.GetAll(skip, nb));
            else
                return View(_productService.GetAll(0, 5));
        }
        public async Task<IActionResult> Create()
        {
            if (Request.Method == "GET")
                return View();
            else if (Request.Method == "POST")
            {
                ImgHandler imgHandler = new ImgHandler();
                Product product = new Product();
                product.Name = Request.Form["Name"];
                product.Price = Double.Parse(Request.Form["Price"]);
                product.Description = Request.Form["Description"];
                product.Category = Request.Form["Category"];
                product.Stock = int.Parse(Request.Form["Stock"]);
                product.Image = await imgHandler.CopyFileAsync(Request.Form.Files["Image"], _env.WebRootPath + "\\images\\");
                product = _productService.CreateProduct(product);
                return Redirect("/Product/Products");
            }
            else
                return View();
        }

        public async Task<IActionResult> Edit([FromRoute] int id)
        {
            if (Request.Method == "GET")
            {
                Product p = _productService.Get(id);
                return View(p);
            }
            else if (Request.Method == "POST")
            {
                ImgHandler imgHandler = new ImgHandler();
                Product p = new Product();
                p.Name = Request.Form["Name"];
                p.Price = Double.Parse(Request.Form["Price"]);
                p.Description = Request.Form["Description"];
                p.Category = Request.Form["Category"];
                p.Stock = int.Parse(Request.Form["Stock"]);
                p.ProductId = id;
                if (Request.Form.Files.Count == 0)
                    p.Image = _productService.Get(id).Image;
                else
                    p.Image = await imgHandler.CopyFileAsync(Request.Form.Files["Image"], _env.WebRootPath + "\\images\\");
                p = _productService.EditProduct(p);
                return Redirect("/Product/Products");
            }
            else
                return View();
        }

        public IActionResult Delete([FromRoute] int id)
        {
            if (Request.Method == "GET")
            {
                _productService.DeleteProduct(id);

                return Redirect("/Product/Products");
            }
            else
                return View();
        }


        public IActionResult Details([FromRoute] int id)
        {
            if (Request.Method == "GET")
                return View(_productService.Get(id));
            else
                return View();
        }
    }
}