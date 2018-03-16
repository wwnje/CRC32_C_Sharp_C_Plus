using Utility.CRC32;
using System;
using Utility.MD5;

namespace CRC32_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "Hello, World!";
            uint crc_result = CRC32.GetCRC32(msg);
            uint crc_result_2 = CRC32.GetCRC32_2(msg);

            string messageMd5 = MD5.GetMd5(msg);

            Console.WriteLine(crc_result);
            Console.WriteLine(crc_result_2);
            Console.WriteLine(messageMd5);
            Console.ReadLine();
        }
    }
}

