using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;


namespace mail
{
    class Util
    {
        public static string getMd5(string encryptStr)
        {
            System.Security.Cryptography.MD5 md5 = new MD5CryptoServiceProvider();
            byte[] bytResult = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(encryptStr));
            string strResult = BitConverter.ToString(bytResult);
            strResult = strResult.Replace("-", "");
            return strResult;
        }
    }
}
