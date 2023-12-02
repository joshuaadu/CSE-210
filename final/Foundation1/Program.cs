using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");
        List<Video> videos = new List<Video>();
        videos.Add(new Video("The Matrix", "A movie about a computer programmer who discovers the truth about reality", "https://www.youtube.com/watch?v=m8e-FF8MsqU", 120, "The Wachowskis"));
        videos.Add(new Video("The Matrix Reloaded", "A movie about a computer programmer who discovers the truth about reality", "https://www.youtube.com/watch?v=zsgrsiZoymA", 138, "The Wachowskis"));
        videos.Add(new Video("The Matrix Revolutions", "A movie about a computer programmer who discovers the truth about reality", "https://www.youtube.com/watch?v=5KV5Mr9LxZ0", 129, "The Wachowskis"));
        videos.Add(new Video("The Matrix Resurrections", "A movie about a computer programmer who discovers the truth about reality", "https://www.youtube.com/watch?v=9ix7TUGVYIo", 148, "The Wachowskis"));

        videos[0].AddComment(new Comment("This is a comment", "John Doe"));
        videos[0].AddComment(new Comment("This is another comment", "Jane Doe"));
        videos[0].AddComment(new Comment("This is a third comment", "John Doe"));
        videos[0].AddComment(new Comment("This is a fourth comment", "Jane Doe"));

        videos[1].AddComment(new Comment("This is a comment", "John Doe"));
        videos[1].AddComment(new Comment("This is another comment", "Jane Doe"));
        videos[1].AddComment(new Comment("This is a third comment", "John Doe"));
        videos[1].AddComment(new Comment("This is a fourth comment", "Jane Doe"));

        videos[2].AddComment(new Comment("This is a comment", "John Doe"));
        videos[2].AddComment(new Comment("This is another comment", "Jane Doe"));
        videos[2].AddComment(new Comment("This is a third comment", "John Doe"));
        videos[2].AddComment(new Comment("This is a fourth comment", "Jane Doe"));

        videos[3].AddComment(new Comment("This is a comment", "John Doe"));
        videos[3].AddComment(new Comment("This is another comment", "Jane Doe"));
        videos[3].AddComment(new Comment("This is a third comment", "John Doe"));
        videos[3].AddComment(new Comment("This is a fourth comment", "Jane Doe"));

        foreach (Video video in videos)
        {
            Console.WriteLine(video);
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}