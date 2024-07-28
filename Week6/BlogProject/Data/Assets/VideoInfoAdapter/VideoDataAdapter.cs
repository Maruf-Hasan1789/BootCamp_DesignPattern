using BlogProject.Entities;

namespace BlogProject.Data.Assets.VideoInfoAdapter;

public class VideoDataAdapter : IAdapterVideoData
{
    private VideoDataAdaptee adaptee;
    public VideoDataAdapter(VideoDataAdaptee videoDataAdaptee)
    {
        adaptee = videoDataAdaptee;
    }
    
    public List<VideoInfo> GetVideoInfos(List<VideoData> videoDatas)
    {
        return adaptee.GetVideoInfos(videoDatas);
    }
}
