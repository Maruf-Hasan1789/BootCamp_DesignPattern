using System.ComponentModel.DataAnnotations;

namespace BlogProject.Entities;

public record VideoInfo
{
    [Key]
    public int VideoId {get;set;}
    public string VideoUrl {get;set;}
}
