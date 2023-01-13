namespace UploadFiles.Services
{
    public interface IImageUploadService
    {
        public Task<string> UploadFileAsync(IFormFile file);
    }
}
