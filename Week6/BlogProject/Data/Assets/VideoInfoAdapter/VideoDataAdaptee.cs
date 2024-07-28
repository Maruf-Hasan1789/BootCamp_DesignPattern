using BlogProject.Data.Assets;
using BlogProject.Entities;

namespace BlogProject.Data.Assets.VideoInfoAdapter;

public class VideoDataAdaptee
{
    public List<VideoInfo> GetVideoInfos(List<VideoData> videoData)
    {
        List<VideoInfo> videoInfos = new();
        foreach(var vdata in videoData)
        {
            videoInfos.Add(GetVideoInfo(vdata));
        }
        return videoInfos;
    }

    private VideoInfo GetVideoInfo(VideoData videoData)
    {
        return new(){
            VideoId = int.Parse(videoData.Id),
            VideoUrl = videoData.VideoUrl
        };
    }
}
