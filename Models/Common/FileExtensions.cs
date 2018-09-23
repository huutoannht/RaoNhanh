using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Drawing;

namespace NetCore.Models.Common
{

    public static class FileExtensions
    {
        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars =
            "abcdefghijklmnopqrstuvwxyz1234567890".ToCharArray();
            byte[] data = new byte[1];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetNonZeroBytes(data);
                data = new byte[maxSize];
                crypto.GetNonZeroBytes(data);
            }
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }

        public static string UploadImage(IFormFile file,string path)
        {
            string pathDB = string.Empty;
            if (file!=null&& file.Length > 0)
            {
                var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                var myUniqueFileName = Convert.ToString(Guid.NewGuid());
                var FileExtension = Path.GetExtension(fileName);
                var newFileName = myUniqueFileName + FileExtension;
                fileName = path + $@"\{newFileName}";
                pathDB = Constants.LocaltionImageDb + newFileName;
                using (FileStream fs = System.IO.File.Create(fileName))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                }
            }
            return pathDB;
        }
    }
}