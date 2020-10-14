using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Ecommerce.Utils
{
    public class PasswordHasherd
    {
        public string HashPassword(string clear_pwd)
        {
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            string hashed = Convert.ToBase64String(
                KeyDerivation.Pbkdf2(password: clear_pwd,
                                     salt: salt,
                                     prf: KeyDerivationPrf.HMACSHA1,
                                     iterationCount: 10000,
                                     numBytesRequested: 256 / 8));
            return hashed;
        }
    }
}
