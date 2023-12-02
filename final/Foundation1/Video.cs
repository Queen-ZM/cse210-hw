// Abstract class to represent a video
public abstract class VideoBase
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    public List<CommentBase> Comments { get; set; } = new List<CommentBase>();

    // Abstract method to getting the number of comments
    public abstract int GetNumberOfComments();
}

// Concrete class for videos
public class Video : VideoBase
{
    // Constructor for Video
    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
    }

    // Implementation of abstract method to get the number of comments
    public override int GetNumberOfComments()
    {
        return Comments.Count;
    }
}