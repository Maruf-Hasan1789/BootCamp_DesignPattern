using BlogProject.Data;
using BlogProject.DTO;

namespace BlogProject.Endpoints;

public static class BlogEndPoints
{
    public static List<PostInformation> allPosts = new();
    public static List<CommentData> allComments = new();
    public static WebApplication MapEndpoints(this WebApplication app)
    {
        app.MapGet("/posts", () => allPosts);

        app.MapPost("/posts",(CreatePostDTO newPost) =>
        {
            var newPostDetails = new PostInformation()
            {
                PostId = allPosts.Count + 1,
                Title = newPost.Title,
                Content = newPost.Content,
            };

            allPosts.Add(newPostDetails);
            return Results.Ok(newPostDetails);
        }).WithParameterValidation();
        
        app.MapGet("/comments", ()=>allComments);
        app.MapPost("/comments",(CreateComment createComment)=>{
            var newComment = new CommentData()
            {
                CommentId = allComments.Count+1,
                Comment = createComment.Comment
            };
            allComments.Add(newComment);
            return Results.Ok(newComment);
        }).WithParameterValidation();
        return app;
    }
}
