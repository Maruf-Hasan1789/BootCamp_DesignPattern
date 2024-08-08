using System.Text.Json;
using System.Text.Json.Serialization;
using BlogProject.Data.Assets.VideoInfoAdapter;
using BlogProject.Entities;
using BlogProject.Logger;

namespace BlogProject.Data.Assets;

public class VideoInfoYoutube : IVideoInfoDb
{
    private YoutubeClient youtubeClient;
    private VideoDataAdapter videoDataAdapter;
    public VideoInfoYoutube(YoutubeClient youtubeClient, VideoDataAdapter videoDataAdapter)
    {
        this.youtubeClient = youtubeClient;
        this.videoDataAdapter = videoDataAdapter;
    }

    public async Task<List<VideoInfo>> GetAllVideoInfos()
    {
        var videoDatas = await youtubeClient.GetAllYoutubeData();
        return videoDataAdapter.GetVideoInfos(videoDatas); 
    }
}


public class YoutubeClient
{
    public async Task<List<VideoData>> GetAllYoutubeData()
    {
         List<VideoData> videodata = new();
        using var client = new HttpClient();
        string Url = "https://gist.githubusercontent.com/poudyalanil/ca84582cbeb4fc123a13290a586da925/raw/14a27bd0bcd0cd323b35ad79cf3b493dddf6216b/videos.json";
        var response = client.GetAsync(Url).Result;
        if(response.IsSuccessStatusCode)
        {
            string jsonData = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            videodata = JsonSerializer.Deserialize<List<VideoData>>(jsonData,options);
        }
        return videodata;
    }
}


public class VideoData
{
    public string Id {get;set;}
    public string Title {get;set;}
    public string ThumbnailUrl {get;set;}
    public string Duration {get;set;}
    public string UploadTime {get;set;}
    public string Views {get;set;}
    public string Author {get;set;}
    public string VideoUrl {get;set;}
    public string Description {get;set;}
    public string Subscriber {get;set;}
    public bool IsLive {get;set;}
}