using System.ComponentModel.DataAnnotations;

namespace BlogProject;

public record CreateComment
{
    [Required][StringLength(100)]public string Comment {get;set;}
}
