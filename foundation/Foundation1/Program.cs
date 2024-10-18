using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("What is it like to study at BYU", "Guilherme Melo", 600);
        Video video2 = new Video("General Conference October 2023", "Church of Jesus Christ of Latter-days Saints", 15000);
        Video video3 = new Video("BYU Idaho Campus Tour", "BYU Idaho", 900);

        video1.AddComment(new Comment("Isabelle", "Great introduction!"));
        video1.AddComment(new Comment("Guilherme", "This was very helpful."));
        video1.AddComment(new Comment("Jhon", "Looking forward to the next part."));

        video2.AddComment(new Comment("Anna", "Inspiring speeches."));
        video2.AddComment(new Comment("Peter", "Always good to hear our prophet!"));

        video3.AddComment(new Comment("Emma", "Looking forward to studying."));
        video3.AddComment(new Comment("David", "The campus is very beautiful."));


        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            video.DisplayInformation();
            Console.WriteLine();
        }
    }
}