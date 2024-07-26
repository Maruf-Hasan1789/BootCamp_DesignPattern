using BlogProject.Entities;

namespace BlogProject.Data.Assets;

public interface IVideoInfoDb
{
    public List<VideoInfo> GetAllVideoInfos(VideoInfoContext dbContext);
}
