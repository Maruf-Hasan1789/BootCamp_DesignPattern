using BlogProject.Data;

namespace BlogProject.DTO;

public record class UpdateScore
{
    public int PostId {get;set;}
    public int PostAuthorId {get;set;}
    public int UserId {get;set;}
}
