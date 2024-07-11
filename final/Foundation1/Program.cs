using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to eat an apple", "Johnny Appleseed", 600);
        video1.AddComment(new Comment("Anon", "That is the wrong way."));
        video1.AddComment(new Comment("Doug", "I could do that with my eyes closed"));

        Video video2 = new Video("How to not code C#", "Somebody Important", 1000);
        video2.AddComment(new Comment("The Boss", "I don't agree I think this is how to code C#"));
        video2.AddComment(new Comment("James", "I learned a lot! thank you"));

        Video video3 = new Video("Best Chicken Ever", "Sir Hennington", 500);
        video3.AddComment(new Comment("Ilovecows221", "Everybody should eat chicken"));

        List<Video> videos = new List<Video> {video1, video2, video3};

        foreach(Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()}");
            Console.WriteLine($"Number of comments: {video.GetCommentAmount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommentName()}: {comment.GetComment()}");
            }
            Console.WriteLine();
        }
    }
}