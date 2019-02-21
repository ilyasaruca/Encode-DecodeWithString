using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encode_DecodeWithString
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "3myna7kz3q7j";
            Console.WriteLine("Original Password : {0}", string.Format(password));

            var encrypt = MD5.Encrypt(password);
            Console.WriteLine("Encrypt Password  : {0}", string.Format(encrypt));

            var decrypt = MD5.Decrypt(encrypt);
            Console.WriteLine("Decrypt Password  : {0}", string.Format(decrypt));

            Console.ReadKey();
        }
    }
}
