using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using CloudinaryDotNet.Actions;

namespace API.Interfaces
{
    public interface IPhotoServices
    {
        Task<ImageUploadResult> AddPhotoAsync(IFormFile file);

        Task<DeletionResult> DeletePhotoAsync(string publicId);
    }
}


