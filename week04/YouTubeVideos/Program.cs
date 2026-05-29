using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Beginner C# Tutorial", "Code Teacher", 600);
        video1.AddComment(new Comment("John", "This helped me understand classes."));
        video1.AddComment(new Comment("Emily", "Great explanation!"));
        video1.AddComment(new Comment("Chris", "Please make more tutorials."));

        Video video2 = new Video("Gaming Setup Tour", "Tech Gamer", 420);
        video2.AddComment(new Comment("Alex", "That setup looks awesome."));
        video2.AddComment(new Comment("Sarah", "I like the keyboard."));
        video2.AddComment(new Comment("Mike", "Great video quality."));

        Video video3 = new Video("How Solar Panels Work", "Solar Guide", 750);
        video3.AddComment(new Comment("Ben", "Very useful information."));
        video3.AddComment(new Comment("Rachel", "This made solar easier to understand."));
        video3.AddComment(new Comment("David", "Thanks for explaining it simply."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}