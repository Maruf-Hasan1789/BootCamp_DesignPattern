namespace BlogProject.Data;

public record class PostInformation
{
    public int PostId {get;set;}
    public string Title {get;set;}
    public string Content {get;set;}
    public int PostAuthorId {get;set;}
}