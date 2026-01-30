using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Step 3a: Create videos
        var video1 = new Video("Learn C# in 10 Minutes", "CodeAcademy", 600);
        video1.AddComments(new Comments("Alice", "Great video!"));
        video1.AddComments(new Comments("Bob", "really helpful, thanks."));
        video1.AddComments(new Comments("millie", "I learned a lot! Thanks a lot for this"));

        var video2 = new Video("Top 5 Programming Mistakes", "Greatdev", 900);
        video2.AddComments(new Comments("David", "Number 3 surprised me!"));
        video2.AddComments(new Comments("Eve", "Good insights."));
        video2.AddComments(new Comments("Frank", "Thanks for sharing!"));

        var video3 = new Video("Introduction to Algorithms", "AlgoExpert", 1200);
        video3.AddComments(new Comments("Grace", "Excellent explanation."));
        video3.AddComments(new Comments("Heidi", "Could you make a part 2?"));
        video3.AddComments(new Comments("Ivan", "Loved the visuals."));

        // Step 3b: Add videos to a list
        var videos = new List<Video> { video1, video2, video3 };

        // Step 3c: Display video info and comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            video.DisplayComments();
            Console.WriteLine(); // blank line for readability
        }
    }
}
