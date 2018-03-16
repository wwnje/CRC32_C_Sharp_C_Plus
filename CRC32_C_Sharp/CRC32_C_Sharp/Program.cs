using KernelCore.Utility.Encrypt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRC32_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "Hello, World233!";
            uint crc_result = CRC32.GetCRC32(msg);
            uint crc_result_2 = CRC32.GetCRC32_2(msg);

            byte[] bytes = BitConverter.GetBytes(crc_result);
            string message = Convert.ToBase64String(bytes);

            string messageMd5 = Md5.GetMd5(msg);

            Console.WriteLine(crc_result);
            Console.WriteLine(crc_result_2);

            //Console.WriteLine(message);
            //Console.WriteLine(messageMd5);
            Console.ReadLine();
        }
    }
}

