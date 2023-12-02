using System;
using System.Collections.Generic;

// Abstract class to represent a comment
public abstract class CommentBase
{
    public string CommenterName { get; set; }
    public string CommentText { get; set; }
}

// Concrete class for comments
public class Comment : CommentBase
{
    // Constructor for Comment
    public Comment(string commenterName, string commentText)
    {
        CommenterName = commenterName;
        CommentText = commentText;
    }
}