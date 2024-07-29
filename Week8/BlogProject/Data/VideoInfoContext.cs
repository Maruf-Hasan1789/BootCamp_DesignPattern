namespace BlogProject.Data;

using BlogProject.Entities;
using Microsoft.EntityFrameworkCore;


public class VideoInfoContext(DbContextOptions<VideoInfoContext> options) 
            : DbContext(options)
{
    public DbSet<VideoInfo> VideoInfos => Set<VideoInfo>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<VideoInfo>().HasData(
            new VideoInfo(){
                        VideoId = 1,
                        VideoUrl = "https://www.youtube.com/watch?v=iDQAZEJK8lI&list=PLoILbKo9rG3skRCj37Kn5Zj803hhiuRK6"
            },
                  new VideoInfo(){
                        VideoId = 2,
                        VideoUrl = "https://www.youtube.com/watch?v=GCraGHx6gso"
            },
                  new VideoInfo(){
                        VideoId = 3,
                        VideoUrl = "https://www.youtube.com/watch?v=NwaabHqPHeM"
            },
                  new VideoInfo(){
                        VideoId = 4,
                        VideoUrl = "https://www.youtube.com/watch?v=tK9Oc6AEnR4"
            },
                  new VideoInfo(){
                        VideoId = 5,
                        VideoUrl = "https://www.youtube.com/watch?v=6gwF8mG3UUY"
            }
        );
    }
}
