using System;
using Feed.Entities;

namespace Feed
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a Nice Trip");
            Comment c2 = new Comment("Wow, that's awesome!");
            Post p1 = new Post(
                DateTime.Parse("22/09/2020 00:00:18"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country",
                12
            );
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good Night");
            Comment c4 = new Comment("May the force be with you!");
            Post p2 = new Post(
                DateTime.Parse("28/07/2019 12:21:17"),
                "Good Night Guys",
                "See you tomorrow",
                5
            );
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
