using BlogProject.Entities;

namespace BlogProject.Data.Assets;

public interface IVideoInfoDb
{
    public Task<List<VideoInfo>> GetAllVideoInfos();
}
