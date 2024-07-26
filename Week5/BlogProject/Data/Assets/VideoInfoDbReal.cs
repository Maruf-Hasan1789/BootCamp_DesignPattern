using BlogProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogProject.Data.Assets;

public class VideoInfoDbReal : IVideoInfoDb
{
    public List<VideoInfo> GetAllVideoInfos(VideoInfoContext dbContext)
    {
        var videoInfoList = dbContext.VideoInfos.ToList();
        return videoInfoList;
    }
}
