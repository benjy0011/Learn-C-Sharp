using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ClassDemo.Utils
{
    public static class PersonHelper
    {
        // Ctrl + K + E = shorcut for formatting

        // Static class is like Console., u can use it without instantiating
        public static string GenerateIdHelper(string prefix)
        {
            var randomNumber = RandomNumberGenerator
                .GetInt32(100000, 9999999)
                .ToString();
            return $"{prefix}-{randomNumber}";
        }
    }
}
