using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Timers;
using System.Text.RegularExpressions;


      namespace Randomizer
{






    public class Key
    {


        public static string randomizer()
        {
            // Generating a random alphanumeric string with the Security.CryptoGraphy
            var rBytes = new byte[24];
            using (var crypto = new RNGCryptoServiceProvider()) crypto.GetBytes(rBytes);
            var base64 = Convert.ToBase64String(rBytes);
            var result = Regex.Replace(base64, "[A-Za-z0-9]", "");

            // Returns the result as a string
            return result;
        }

    }
}   