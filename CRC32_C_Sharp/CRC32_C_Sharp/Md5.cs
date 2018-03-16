using System;
using System.Security.Cryptography;
using System.Text;

namespace Utility.MD5
{
    class MD5
    {
        public static string GetMd5(string message)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(message));
            return Convert.ToBase64String(bytes);
        }
    }
}
