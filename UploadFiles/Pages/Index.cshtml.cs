using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UploadFiles.Services;

namespace UploadFiles.Pages
{
    public class IndexModel : PageModel
    {
        public string filePath;

        private readonly IImageUploadService imageUploadService;

        public IndexModel(IImageUploadService imageUploadService)
        {
            this.imageUploadService = imageUploadService;
        }

        public void OnGet()
        {
        }

        public async void OnPost(IFormFile file)
        {
            if(file != null)
            {
                filePath = await imageUploadService.UploadFileAsync(file);
            }
        }
    }
}
