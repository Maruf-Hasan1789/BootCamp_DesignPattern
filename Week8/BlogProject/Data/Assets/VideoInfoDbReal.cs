using BlogProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogProject.Data.Assets;

public class VideoInfoDbReal : IVideoInfoDb
{
    private VideoInfoContext dbContext;
    public VideoInfoDbReal(VideoInfoContext dbContext)
    {
        this.dbContext = dbContext;
    }
    
    public Task<List<VideoInfo>> GetAllVideoInfos()
    {
        var videoInfoList = dbContext.VideoInfos.ToListAsync();
        return videoInfoList;
    }
}
