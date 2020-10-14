using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Ecommerce.Dao;
using Ecommerce.Models;
using Ecommerce.Utils;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly MyDbContext _context;


        public UsersController(MyDbContext context)
        {
            _context = context;
        }

        // GET sur user par ID
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            User user = _context.Users.Include(p => p.ListAddresses).FirstOrDefault(p => p.UserId == id);
            if (user != null)
                return Ok(user);
            return NotFound();
        }

        // GET api/users retourne tous les users
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAllUsers()
        {
            List<User> ListUser = _context.Users.Include(p => p.ListAddresses).ToList();
            //foreach (User u in ListUser)
            //    _context.Entry(u).Reference(p => p.ListAddresses)
            return ListUser;
        }

        // POST api/users pour créer les users
        [HttpPost]
        public ObjectResult CreateUser([FromBody]User value)
        {
            PasswordHasher<string> pw = new PasswordHasher<string>();
            string pwd = pw.HashPassword(value.Email, value.Password);

            User user = _context.Users.FirstOrDefault(p => p.Email == value.Email);
            if (user != null)
                return Conflict(new Error { Type = "Error", Msg = $"User {value.Email} already exists." });

            value.Password = pwd;
            _context.Users.Add(value);
            _context.SaveChanges();
            return Created(uri:"", value: value);
        }

        // PUT api/users pour update les users
        [HttpPut]
        public ActionResult UpdateUser([FromBody]User value)
        {
            User user = _context.Users.FirstOrDefault(p => p.UserId == value.UserId);
            if (user == null)
                return NotFound();
            if (value.Email != user.Email && value.Email != null)
                return NotFound(new Error { Type = "Error", Msg = "Email can't be modified." });
            user.FirstName = value.FirstName != null ? value.FirstName : user.FirstName; 
            user.LastName = value.LastName != null ? value.LastName : user.LastName; 

            _context.Users.Attach(user);
            _context.Entry(user).Property(x => x.FirstName).IsModified = true;
            _context.Entry(user).Property(x => x.LastName).IsModified = true;
            _context.Users.Update(user);
            _context.SaveChanges();
            return Ok(value);
        }

        // DELETE api/users/{id} pour Delete un user
        [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            User user = new User { UserId = id };
            _context.Users.Remove(user);
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
