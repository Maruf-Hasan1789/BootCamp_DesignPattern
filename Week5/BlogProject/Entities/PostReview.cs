namespace BlogProject.Entities;

public record PostReview
{
    public int PostId {get;set;}
    public string ReviewTitle{get;set;}
    public string Content {get;set;}
    public int Rating {get;set;}
    public string Pros {get;set;}
    public string Cons {get;set;}
    public string Recommendation {get;set;}
    public string Idea {get;set;}
    public string Author_FeedBack {get;set;}
}

public interface ISetReviewTitle
{
    public PostReviewBuilder SetReviewTitle(string reviewTitle);
}


public class PostReviewBuilder : ISetReviewTitle
{
    private PostReview _postReview = new();

    public PostReviewBuilder SetPostId(int postId)
    {
        _postReview.PostId = postId;
        return this;
    }

    public PostReviewBuilder SetReviewTitle(string reviewTitle)
    {
        _postReview.ReviewTitle = reviewTitle;
        return this;
    }

    public PostReviewBuilder SetContent(string content)
    {
        _postReview.Content = content;
        return this;
    }

    public PostReviewBuilder SetRating(int rating)
    {
        _postReview.Rating = rating;
        return this;
    }

    public PostReviewBuilder SetPros(string pros)
    {
        _postReview.Pros = pros;
        return this;
    }

    public PostReviewBuilder SetCons(string cons)
    {
        _postReview.Cons = cons;
        return this;
    }

    public PostReviewBuilder SetRecommendation(string recommendation)
    {
        _postReview.Recommendation = recommendation;
        return this;
    }

    public PostReviewBuilder SetIdea(string idea)
    {
        _postReview.Idea = idea;
        return this;
    }

    public PostReviewBuilder SetAuthor_FeedBack(string author_FeedBack)
    {
        _postReview.Author_FeedBack = author_FeedBack;
        return this;
    }
    
    public PostReview Build()
    {
        return _postReview;
    }
}