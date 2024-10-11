using System;

class Program
{
    static void Main(string[] args)
    {
        //create video
        Video video1 = new Video("C# Tutorial", "Therese Gasmen", 600);
        Video video2 = new Video("Learn Python", "Pamela Gasmen", 900);
        Video video3 = new Video("Java Basics", "Denniel Gasmen", 1200);
        //add comments
        video1.AddComment(new Comment("Lea", "Great tutorial!"));
        video1.AddComment(new Comment("Willy", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Karla", "Clear explanation!"));
        video2.AddComment(new Comment("James", "I love Python!"));
        video2.AddComment(new Comment("Eli", "Very informative."));
        video3.AddComment(new Comment("Alta", "Thanks for the tips!"));
        video3.AddComment(new Comment("Alex", "Java seems interesting."));
        video3.AddComment(new Comment("Arlene", "Looking forward to more content!"));

        List<Video> videos = new List<Video> { video1, video2, video3};

        foreach (var video in videos) {
            Console.WriteLine($"Title: {video.Title}, Author: {video.Author}, Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");

            foreach (var comment in video.GetComments()) {
                Console.WriteLine($" - {comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine();
        }
    }
}