using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Models;
using Ecommerce.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : Controller
    {
        private readonly MyDbContext _context;

        public AddressesController(MyDbContext context)
        {
            _context = context;
        }

        [HttpGet("{userId:int}")]
        public ActionResult<IEnumerable<Address>> GetAllAddressesByUser(int userId)
        {
            List<Address> addresses = _context.Addresses.Where(p => p.User.UserId == userId).ToList();
            /*
            foreach (Address cp in addresses)
                _context.Entry(cp).Reference(p => p.User).Load();
            */
            return addresses;
        }

        // POST api/users  créer les users
        [HttpPost("{userId:int}")]
        public ObjectResult AddAddress([FromBody]Address value, [FromRoute]int userId)
        {
            User user = _context.Users.FirstOrDefault(p => p.UserId == userId);
            if (user == null)
                return NotFound(new Error { Type = "Error", Msg = $"User {userId} doesn't exists." });
            List<Address> address = _context.Addresses.Where(p => p.IsBill == true && p.User == user).ToList();
            if (address.Count != 0 && value.IsBill)
                return Conflict(new Error { Type = "Error", Msg = $"A billing address already exists." });
            if (user.ListAddresses == null)
                user.ListAddresses = new List<Address>();

            value.User = user;
            user.ListAddresses.Add(value);
            _context.Users.Attach(user);
            _context.Entry(user).Collection(x => x.ListAddresses).IsModified = true;
            _context.Addresses.Add(value);
            _context.SaveChanges();
            return Created(uri: "", value: value);
        }

        [HttpDelete("{userId:int}/{addressId:int}")]
        public ActionResult RemoveAddress([FromRoute]int addressId, [FromRoute]int userId)
        {
            Address address = new Address() { AddressId = addressId };
            User user = _context.Users.FirstOrDefault(p => p.UserId == userId);
            if (user == null)
                return NotFound(new Error { Type = "Error", Msg = $"User {userId} doesn't exists." });
            _context.Addresses.Remove(address);
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