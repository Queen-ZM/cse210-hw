class Program
{
    static void Main()
    {
        // Create a list to store videos
        List<VideoBase> videos = new List<VideoBase>();

        // Videos and add comments
        Video video1 = new Video("Introduction to C#", "Programming with Mosh", 300);
        video1.Comments.Add(new Comment("Alice", "Great video!"));
        video1.Comments.Add(new Comment("Bob", "I learned a lot."));
        video1.Comments.Add(new Comment("Charlie", "Keep it up!"));

        Video video2 = new Video("Euclidean geometry", "April Smith", 400);
        video2.Comments.Add(new Comment("David", "Very informative."));
        video2.Comments.Add(new Comment("Eva", "Could you provide more examples?"));

        Video video3 = new Video("How to make a dress", "Siphokazi Woko", 250);
        video3.Comments.Add(new Comment("Grace", "Helped me understand stitching."));
        video3.Comments.Add(new Comment("Henry", "Clear explanation."));

        // videos added to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Information for each video
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length (seconds): {video.LengthInSeconds}");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"{comment.CommenterName}: {comment.CommentText}");
                Console.WriteLine();
            }

           
        }
    }
}
