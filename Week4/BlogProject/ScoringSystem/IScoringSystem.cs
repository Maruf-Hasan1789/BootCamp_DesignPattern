using System.ComponentModel;

namespace BlogProject.ScoringSystem;

public interface IScoringSystem
{
    void AddScore(int postId, int postAuthorId, int userId);
    void RemoveScore(int postId, int userId);
    void ResetScore();
    int GetScoreOfAuthor(int userId);
    int GetScoreOfPost(int postId);
}
