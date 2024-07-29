namespace BlogProject.Entities;

public record UserInfo
{
    public int UserId {get;set;}
    public string UserName {get;set;}
    public UserRoleEnum UserRole {get;set;}
}


public enum UserRoleEnum
{
    Admin,
    Regular
}
