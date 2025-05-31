using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Comment comment1 = new Comment("Sally Brown", "My brothers are the cutest!");
        Comment comment2 = new Comment("Pigpen", "I never knew Charlie had an older brother.");
        Comment comment3 = new Comment("Lucy van Pelt", "Where's the music?");

        Video video1 = new Video("Charlie Bit Me", "Charlie Brown", 30);
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        Comment comment4 = new Comment("Harry Potter", "We got the beats!");
        Comment comment5 = new Comment("Hermione", "Is that really what my hair looks like from the back?");
        Comment comment6 = new Comment("Ron Weasley", "It's bloody brilliant!");

        Video video2 = new Video("The Mysterious Ticking Noise", "Severus Snape", 40);
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        Comment comment7 = new Comment("Samwise Gamgee", "Wait a minute...We went through all that for nothing?!");
        Comment comment8 = new Comment("Merry Brandybuck", "Well I was LOST and wanted a part.");
        Comment comment9 = new Comment("Peregrin Took", "Didn't you like my song?");
        Comment comment10 = new Comment("Mithrandir", "Fly, you fools!");

        Video video3 = new Video("How LOTR Should Have Ended", "Frodo Baggins", 50);
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);
        video3.AddComment(comment10);

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.VideoDisplay();
        }

    }
}