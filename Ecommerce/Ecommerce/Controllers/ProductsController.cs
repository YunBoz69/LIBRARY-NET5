using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly MyDbContext _context;

        public ProductsController(MyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAllProducts()
        {
            List<Product> products = _context.Products.ToList();
            return products;
        }

        [HttpGet("categories")]
        public ActionResult<IEnumerable<Object>> GetCategories()
        {
            List<string> cat = _context.Products.Select(p => p.Category).Distinct().ToList();
            return cat;
        }

        [HttpGet("{skip}/{nb}")]
        public ActionResult<IEnumerable<Product>> GetProductsByRange(int skip, int nb)
        {
            List<Product> products = null;
            if (skip == -1)
            {
                int count = _context.Products.Count();
                if (count - nb < 0)
                    products = _context.Products.Skip(0).Take(nb).ToList();
                else
                    products = _context.Products.Skip(count - nb).Take(nb).ToList();
            }
            else
            {
                products = _context.Products.Skip(skip).Take(nb).ToList();
            }
            return products;
        }
        /*
        [HttpGet()]
        public ActionResult<IEnumerable<Product>> GetProductsByRange([FromQuery] int skip, [FromQuery] int nb, [FromQuery] string category, [FromQuery] double price)
        {
            List<Product> products = null;
            if (skip == -1)
            {
                int count = _context.Products.Count();
                if (count - nb < 0)
                    products = _context.Products.Skip(0).Take(nb).ToList();
                else
                    products = _context.Products.Skip(count - nb).Take(nb).ToList();
            }
            else
            {
                products = _context.Products.Skip(skip).Take(nb).ToList();
            }
            return products;
        }*/

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Product>> GetProductById(int id)
        {
            Product product = _context.Products.FirstOrDefault(p => p.ProductId == id);
            if (product != null)
                return Ok(product);
            return NotFound();
        }

        [HttpPost]
        public ActionResult<IEnumerable<Product>> CreateProduct(Product value)
        {
            _context.Products.Add(value);
            _context.SaveChanges();
            return Created(uri: "", value: value);
        }

        [HttpPut]
        public ActionResult UpdateProduct([FromBody]Product value)
        {
            _context.Products.Update(value);
            _context.SaveChanges();
            return Ok(value);
        }

        // POST api/users pour créer les users
        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            Product product = new Product { ProductId = id };
            _context.Products.Remove(product);
            try
            {
                _context.SaveChanges();

            }
            catch (DbUpdateConcurrencyException e)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
