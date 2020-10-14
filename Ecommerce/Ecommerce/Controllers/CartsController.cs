using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : Controller
    {
        private readonly MyDbContext _context;

        public CartsController(MyDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public ActionResult<Cart> GetCartByUserId(int id)
        {
            Cart cart = _context.Carts.FirstOrDefault(p => p.UserId == id && p.IsActive == true);
            if (cart == null)
                return NotFound();
            _context.Entry(cart).Collection(p => p.ListCartProducts).Load();
            foreach (CartProduct cp in cart.ListCartProducts)
                _context.Entry(cp).Reference(p => p.product).Load();
            return Ok(cart);
        }

        [HttpGet("carts/{id}")]
        public ActionResult<List<Cart>> GetCartsByUserId(int id)
        {
            List<Cart> cart = _context.Carts.Where(p => p.UserId == id && p.IsActive == false).ToList();
            if (cart == null)
                return NotFound();
            return Ok(cart);
        }

        [HttpGet("cart/{id}")]
        public ActionResult<Cart> GetCartByCartId(int id)
        {
            Cart cart = _context.Carts.FirstOrDefault(p => p.CartId == id);
            if (cart == null)
                return NotFound();
            _context.Entry(cart).Collection(p => p.ListCartProducts).Load();
            foreach (CartProduct cp in cart.ListCartProducts)
                _context.Entry(cp).Reference(p => p.product).Load();
            return Ok(cart);
        }

        [HttpPost("addproduct")]
        public ActionResult<Cart> AddProductToCart([FromBody]JObject data)
        {
            Product product = data["productData"].ToObject<Product>();
            User user = data["userData"].ToObject<User>();
            Cart cart = _context.Carts.FirstOrDefault(p => p.UserId == user.UserId && p.IsActive == true);
            CartProduct cartProduct = null;
            int qty = 1;

            if (data["quantity"] != null)
            { 
                qty = data["quantity"].ToObject<int>();
            }

            if (cart == null) {
                cart = new Cart() { IsActive = true, UserId = user.UserId };
                _context.Carts.Add(cart);
            }

            product = _context.Products.FirstOrDefault(p => p.ProductId == product.ProductId);
            cartProduct = _context.CartProducts.FirstOrDefault(p => p.product == product && p.cart == cart);
            if (cartProduct == null) { 
                cartProduct = new CartProduct() { product = product, cart = cart, Quantity = qty };
                _context.CartProducts.Add(cartProduct);
            }
            else
            {
                cartProduct.Quantity += qty;
                _context.CartProducts.Update(cartProduct);
            }
            if (cart.ListCartProducts == null)
                cart.ListCartProducts = new List<CartProduct>();
            cart.ListCartProducts.Add(cartProduct);
            //_context.Carts.Attach(cart);
            _context.Entry(cart).Collection(x => x.ListCartProducts).IsModified = true;
            _context.SaveChanges();
            return Ok();
        }

        [HttpPost("order/{userId}")]
        public ActionResult<Cart> Order([FromRoute]int userId, [FromBody]JObject data)
        {
            Address billing_addr = _context.Addresses.FirstOrDefault(p => p.IsBill == true && p.AddressId == (int)data["bill"]);
            Address delivery_addr = _context.Addresses.FirstOrDefault(p => p.IsDelivery == true && p.AddressId == (int)data["delivery"]);
            Cart cart = _context.Carts.FirstOrDefault(p => p.UserId == userId && p.IsActive == true);
            _context.Entry(cart).Collection(p => p.ListCartProducts).Load();
            foreach (CartProduct cp in cart.ListCartProducts)
            {
                _context.Entry(cp).Reference(p => p.product).Load();
            }
            // Creation de json pour OrderInfo
            JObject bill = new JObject();
            bill["billing_addr"] = (JObject)JToken.FromObject(billing_addr);
            bill["delivery_addr"] = (JObject)JToken.FromObject(delivery_addr);
            bill["products"] = (JArray)JToken.FromObject(cart.ListCartProducts);
            bill["card_name"] = data["card_name"].ToString();
            bill["card_number"] = data["card_number"].ToString();
            bill["cvc"] = data["cvc"].ToString();
            bill["expiration_month"] = data["expiration_month"].ToString();
            bill["expiration_year"] = data["expiration_year"].ToString();
            User user = _context.Users.FirstOrDefault(p => p.UserId == userId);
            if (cart == null)
                return NotFound();
            cart.OrderInfo = JsonConvert.SerializeObject(bill);
            cart.IsActive = false;

            _context.SaveChanges();
            return Ok(cart);
        }

        [HttpPost("removeproduct")]
        public ActionResult<Cart> RemoveProductToCart([FromBody]JObject data)
        {
            Product product = data["productData"].ToObject<Product>();
            User user = data["userData"].ToObject<User>();
            Cart cart = _context.Carts.FirstOrDefault(p => p.UserId == user.UserId && p.IsActive == true);
            CartProduct cartProduct = _context.CartProducts.FirstOrDefault(p => p.cart == cart && p.product == product);
            int qty = 1;

            if (data["quantity"] != null)
                qty = data["quantity"].ToObject<int>();
            if (cart == null || cartProduct == null)
                return NoContent();

            if (qty >= 1)
            { 
                if (cartProduct.Quantity > qty)
                {
                    cartProduct.Quantity -= qty;
                   _context.CartProducts.Update(cartProduct);
                }
                else
                    _context.CartProducts.Remove(cartProduct);
            }
            else
                _context.CartProducts.Remove(cartProduct);
            _context.SaveChanges();
            return Ok();
        }
    }
}
