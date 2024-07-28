
using PexelsDotNetSDK.Api;
using PexelsDotNetSDK.Models;

namespace BlogProject;

public class StockPhotoService : IPhotoService
{
    public async Task<List<Photo>> GetAllPhotosAsync()
    {
        List<Photo>photoDatas = new();
        var pexelsClient = new PexelsClient("1eCUtsJq1mx6Gw0WCXq3Y8imzQfCzdBU6kkDQoKE31YMmGN994YoOWq9");
        var result = await pexelsClient.SearchPhotosAsync("nature");
        return result.photos;
    }
}
