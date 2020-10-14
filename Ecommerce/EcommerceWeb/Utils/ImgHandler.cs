using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing.Printing;
using Microsoft.AspNetCore.Http;

namespace EcommerceWeb.Utils
{
    public class ImgHandler
    {

        public async Task<string> CopyFileAsync(IFormFile file, string path)
        {
            //long size = files.Sum(f => f.Length);

            // full path to file in temp location
            var filePath = Path.GetTempPath();

            //foreach (var formFile in files)
            //{
            if (file.Length > 0)
                {
                    var name = Guid.NewGuid().ToString() + "_" + Path.GetFileName(file.FileName);
                    using (var stream = new FileStream(path+name, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                return name;
                }
            return null;
            //}
        }

        public byte[] ConvertImageBase64(IFormFile inImg)
        {
            string base64String = string.Empty;
            // Convert Image to Base64
            using (var img = System.Drawing.Image.FromFile(inImg.FileName)) // Image Path from File Upload Controller
            {
                using (var memStream = new MemoryStream())
                {
                    img.Save(memStream, img.RawFormat);
                    byte[] imageBytes = memStream.ToArray();

                    //base64String = Convert.ToBase64String(imageBytes);
                    return imageBytes;
                }
            }
            return null;
        }

        public System.Drawing.Image Base64StringToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            var memStream = new MemoryStream(imageBytes, 0, imageBytes.Length);

            memStream.Write(imageBytes, 0, imageBytes.Length);
            var image = System.Drawing.Image.FromStream(memStream);
            return image;
        }
    }
}
