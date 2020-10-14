using Ecommerce.Models;
using Ecommerce.Utils;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : Controller
    {
        private readonly MyDbContext _context;

        public SessionController(MyDbContext context)
        {
            _context = context;
        }
        
        // POST route pour se connecter avec mail/password
        [HttpPost]
        public ActionResult Connect([FromBody] User value)
        {
            PasswordHasher<string> pw = new PasswordHasher<string>();
            User user = _context.Users.FirstOrDefault(p => p.Email == value.Email);
            if (user == null)
                return BadRequest(new Error { Type = "Error", Msg = "Bad credentials" });
            PasswordVerificationResult verify = pw.VerifyHashedPassword(value.Email, user.Password, value.Password);
            if (verify.ToString() == "Success")
                return Ok(user);
            return BadRequest(new Error { Type = "Error", Msg = "Bad credentials" });
        }
    }
}
