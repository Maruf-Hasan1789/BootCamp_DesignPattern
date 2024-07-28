using BlogProject.Entities;

namespace BlogProject.Data.Assets;

public class VideoInfoDbProxy : IVideoInfoDb
{
    private IVideoInfoDb videoInfoSource;

    public VideoInfoDbProxy(IVideoInfoDb videoInfoSource)
    {
        this.videoInfoSource = videoInfoSource;
    }
    
    public async Task<List<VideoInfo>> GetAllVideoInfos()
    {
        var result = await videoInfoSource.GetAllVideoInfos();
        return result;
    }
}
