using PexelsDotNetSDK.Models;

namespace BlogProject;

public interface IPhotoService
{
    public Task<List<Photo>> GetAllPhotosAsync();
}
