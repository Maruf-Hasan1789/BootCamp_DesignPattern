using BlogProject.Entities;
using BlogProject.DTO;
using BlogProject.Logger;
using BlogProject.ScoringSystem;
using BlogProject.Data;
using BlogProject.Data.Assets;

namespace BlogProject.Endpoints;

public static class BlogEndPoints
{
    public static List<PostInformation> allPosts = new();
    public static List<CommentData> allComments = new();
    public static List<PostReview> allReviews = new();
    public static List<UserInfo> users = new()
    {
        new()
        {
            UserId = 1,
            UserName = "A",
            UserRole = UserRoleEnum.Admin
        },
        new()
        {
            UserId = 2,
            UserName = "B",
            UserRole = UserRoleEnum.Regular
        },
        new()
        {
            UserId = 3,
            UserName = "C",
            UserRole = UserRoleEnum.Regular
        },
        new()
        {
            UserId = 4,
            UserName = "D",
            UserRole = UserRoleEnum.Admin
        },
        new()
        {
            UserId = 5,
            UserName = "E",
            UserRole = UserRoleEnum.Regular
        },
        new()
        {
            UserId = 6,
            UserName = "A",
            UserRole = UserRoleEnum.Regular
        }
    };

    public static WebApplication MapEndpoints(this WebApplication app)
    {
        LogWriter Logger = LogWriter.GetInstance();
        IScoringSystem scoringSystem = new PostAndAuthorScoringSystem(users);

        app.MapGet("/posts", () => allPosts);

        app.MapGet("/posts/{postId}",(int PostId)=>{
            var post = allPosts.Find(post => post.PostId==PostId);
            return post == null ? Results.NotFound() : Results.Ok(post);
        });

        app.MapPost("/posts",(CreatePostDTO newPost) =>
        {
            var newPostDetails = new PostInformation()
            {
                PostId = allPosts.Count + 1,
                Title = newPost.Title,
                Content = newPost.Content,
                PostAuthorId = newPost.PostAuthorId
            };
         
            Logger.LogWrite(newPostDetails.ToString());
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
            Logger.LogWrite(newComment.ToString());
            return Results.Ok(newComment);
        }).WithParameterValidation();

        app.MapPost("/posts/scores",(UpdateScore updateScore) =>{
            scoringSystem.AddScore(updateScore.PostId,updateScore.PostAuthorId, updateScore.UserId);
            var user = users.Find(user => user.UserId == updateScore.UserId);
            ScoreResponse scoreResponse = new()
            {
                AuthorScore = scoringSystem.GetScoreOfAuthor(updateScore.PostAuthorId),
                PostScore = scoringSystem.GetScoreOfPost(updateScore.PostId)
            };

            Logger.LogWrite(scoreResponse.ToString());
            return Results.Ok(scoreResponse);
        }).WithParameterValidation();

        app.MapPost("/reviews/{postId}",(int postId,CreateReview createReview) =>{
            var reviewData = new PostReviewBuilder()
                                .SetReviewTitle(createReview.ReviewTitle)
                                .SetPostId(postId)
                                .SetContent(createReview.Content)
                                .SetRating(createReview.Rating)
                                .SetPros(createReview.Pros)
                                .SetCons(createReview.Cons)
                                .SetRecommendation(createReview.Recommendation)
                                .SetIdea(createReview.Idea)
                                .SetAuthor_FeedBack(createReview.Author_FeedBack)
                                .Build();
            allReviews.Add(reviewData);
            return Results.Ok(reviewData);
        }).WithParameterValidation();


        app.MapGet("/videos", async (VideoInfoDbProxy videoInfoProxy)=> {
            var videoInfoList = await videoInfoProxy.GetAllVideoInfos();
            return Results.Ok(videoInfoList);
        });
    
        app.MapGet("/videos/v2", async (VideoInfoDbProxy videoInfoProxy) => {
            var videoInfoList = await videoInfoProxy.GetAllVideoInfos();
            return Results.Ok(videoInfoList);
        });

        return app;
    }
}
