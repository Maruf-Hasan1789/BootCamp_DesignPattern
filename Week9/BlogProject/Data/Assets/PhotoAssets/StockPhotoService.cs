
using PexelsDotNetSDK.Api;
using PexelsDotNetSDK.Models;

namespace BlogProject;

public class StockPhotoService : IPhotoService
{
    private IPhotoAdapter photoAdapter;
    public StockPhotoService(IPhotoAdapter photoAdapter)
    {
        this.photoAdapter = photoAdapter;
    }

    public async Task<List<PhotoData>> GetAllPhotosAsync()
    {
        List<PhotoData>photoDatas = new();
        var pexelsClient = new PexelsClient("1eCUtsJq1mx6Gw0WCXq3Y8imzQfCzdBU6kkDQoKE31YMmGN994YoOWq9");
        var result = await pexelsClient.SearchPhotosAsync("nature");
        photoDatas = photoAdapter.GetPhotoDataList(result.photos);
        return photoDatas;
    }
}


public interface IPhotoAdapter
{
    List<PhotoData> GetPhotoDataList(List<Photo> photo);
}


public class PhotoAdapter : IPhotoAdapter
{
    private Photoadaptee photoadaptee;
    public PhotoAdapter(Photoadaptee photoadaptee)
    {
        this.photoadaptee = photoadaptee;
    }

    public List<PhotoData> GetPhotoDataList(List<Photo> photoList)
    {
        return photoadaptee.GetPhotoDataList(photoList);
    }
}

public class Photoadaptee
{
    public List<PhotoData> GetPhotoDataList(List<Photo> photoList)
    {
        List<PhotoData> photoDatas = new();
        foreach(var photo in photoList)
        {
            photoDatas.Add(GetPhotoData(photo));
        }
        return photoDatas;
    }

    private PhotoData GetPhotoData(Photo photo)
    {
        return new(){
            Id = photo.id,
            url = photo.url
        };
    }
}