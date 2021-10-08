using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Common
{
    public class PashwordHash
    {
        public string PasswordHash(string passwordIn)
        {
            var algorithm = new MD5CryptoServiceProvider();
            Byte[] inputBytes = Encoding.UTF8.GetBytes(passwordIn);
            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);
            return BitConverter.ToString(hashedBytes);

        }
    }
}
