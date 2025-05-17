using System;
using System.Collections.Generic;

// Comment class
public class Comment
{
    public string CommenterName { get; set; }
    public string Text { get; set; }

    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}

// Video class
public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"\nTitle: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {LengthInSeconds} seconds");
        Console.WriteLine($"Number of comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");
        foreach (var comment in comments)
        {
            Console.WriteLine($" - {comment.CommenterName}: {comment.Text}");
        }
    }
}

// Program class
class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Tutorial", "TechGuru", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I learned a lot."));
        videos.Add(video1);

        Video video2 = new Video("Baking a Cake", "ChefSam", 720);
        video2.AddComment(new Comment("Dana", "Looks delicious!"));
        video2.AddComment(new Comment("Eli", "Can’t wait to try this."));
        video2.AddComment(new Comment("Finn", "Yummy and easy to follow."));
        videos.Add(video2);

        Video video3 = new Video("Yoga for Beginners", "ZenLife", 900);
        video3.AddComment(new Comment("Grace", "So relaxing!"));
        video3.AddComment(new Comment("Henry", "Perfect for mornings."));
        video3.AddComment(new Comment("Isla", "My favorite yoga video."));
        videos.Add(video3);

        Video video4 = new Video("Travel Vlog: Japan", "WanderWorld", 1080);
        video4.AddComment(new Comment("Jack", "Awesome shots!"));
        video4.AddComment(new Comment("Kira", "Japan is on my bucket list."));
        video4.AddComment(new Comment("Leo", "Love this vlog style."));
        videos.Add(video4);

        // Display all video info
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
