using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class SHA1Hasher
    {
        public static string GetHash(string value)
        {
            var key = new byte[] { 1, 7 };
            HMACSHA1 hasher = new HMACSHA1(key);
            byte[] hash = hasher.ComputeHash(Encoding.Unicode.GetBytes(value));

            StringBuilder hashed = new StringBuilder();
            foreach (byte b in hash)
            {
                hashed.Append(b.ToString("x2"));
            }

            return hashed.ToString();
        }
    }
}
