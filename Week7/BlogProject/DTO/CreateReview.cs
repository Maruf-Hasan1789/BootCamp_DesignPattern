using System.ComponentModel.DataAnnotations;

namespace BlogProject.DTO;

public record CreateReview
{
    [Required] [StringLength(1000)]public string ReviewTitle{get;set;}
    public string Content {get;set;}
    [Range(0, 5)] public int Rating {get;set;}
    public string Pros {get;set;}
    public string Cons {get;set;}
    public string Recommendation {get;set;}
    public string Idea {get;set;}
    public string Author_FeedBack {get;set;}
}
