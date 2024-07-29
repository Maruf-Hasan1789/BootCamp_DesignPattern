using System.ComponentModel.DataAnnotations;

namespace BlogProject.DTO;

public record class UpdateScore
{
    [Required]public int PostId {get;set;}
    [Required]public int PostAuthorId {get;set;}
    [Required]public int UserId {get;set;}
}
