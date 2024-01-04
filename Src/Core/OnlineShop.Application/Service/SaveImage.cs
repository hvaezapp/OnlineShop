using Microsoft.AspNetCore.Hosting;
using OnlineShop.Application.Contracts.Service;
using OnlineShop.Infrastructure.Utilities;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace OnlineShop.Application.Service
{
    public class SaveImage : ISaveImage
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public SaveImage(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task<string> Save(string image)
        {
            string fileName = "";

            try
            {
                fileName = AppUtility.GetGuid() + ".png"; 
                string filePath = Path.Combine(_hostingEnvironment.ContentRootPath+"\\uploads\\product\\",fileName);
                await File.WriteAllBytesAsync(filePath,
                              Convert.FromBase64String(image));

            }
            catch (Exception)
            {
               
                throw;
            }

            return fileName;
        }
    }
}
