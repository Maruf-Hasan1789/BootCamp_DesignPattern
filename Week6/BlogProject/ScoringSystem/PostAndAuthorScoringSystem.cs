using BlogProject.Entities;

namespace BlogProject.ScoringSystem;

public class PostAndAuthorScoringSystem : IScoringSystem
{
    private List<PostScore>postScores = new();
    private List<UserScore>userScores = new();
    private List<UserInfo>users;
    
    public PostAndAuthorScoringSystem(List<UserInfo>userList)
    {
        this.users = userList;
    }

    public void AddScore(int postId,int postAuthorId, int userId)
    {
        var user = users.Find(userInfo => userInfo.UserId == userId);
        if(user.UserRole == UserRoleEnum.Admin)
        {
            var postAuthorIndex = userScores.FindIndex(userScore => userScore.UserId == postAuthorId);
            if(postAuthorIndex ==-1)
            {
                userScores.Add(new UserScore()
                {
                    UserId = postAuthorId,
                    Score = 1
                });
            }
            else
            {
                userScores[postAuthorIndex].Score++;
            }
        }
        else
        {
            var postScoreId = postScores.FindIndex(postScore =>(postScore.PostId == postId));
            if(postScoreId == -1)
            {
                postScores.Add(new PostScore()
                {
                    PostId = postId,
                    Score = 1
                });
            }
            else
            {
                postScores[postScoreId].Score++;
            }
        }
    }

    public void RemoveScore(int postId, int userId)
    {
        throw new NotImplementedException();
    }

    public void ResetScore()
    {
        throw new NotImplementedException();
    }

    public int GetScoreOfAuthor(int userId)
    {
        var userScore = userScores.Find(userScore => userScore.UserId == userId);
        return userScore != null ? userScore.Score : 0 ;
    }

    public int GetScoreOfPost(int postId)
    {
        var postScore = postScores.Find(postScore => postScore.PostId == postId);
        return postScore != null ? postScore.Score : 0 ;
    }
}
