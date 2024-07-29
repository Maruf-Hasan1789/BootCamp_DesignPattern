using BlogProject.Data.Assets;
using BlogProject.Entities;

namespace BlogProject.Data.Assets.VideoInfoAdapter;

public interface IAdapterVideoData
{
    List<VideoInfo> GetVideoInfos(List<VideoData> videoData);
}
