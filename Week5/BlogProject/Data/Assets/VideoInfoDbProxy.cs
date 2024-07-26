using BlogProject.Entities;

namespace BlogProject.Data.Assets;

public class VideoInfoDbProxy : IVideoInfoDb
{
    private VideoInfoDbReal videoInfoDbReal;

    public VideoInfoDbProxy(VideoInfoDbReal videoInfoDbReal)
    {
        this.videoInfoDbReal = videoInfoDbReal;
    }
    
    public List<VideoInfo> GetAllVideoInfos(VideoInfoContext dbContext)
    {
        return videoInfoDbReal.GetAllVideoInfos(dbContext);
    }
}
