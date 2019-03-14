using System;
using ConsoleApp6.Entities;


namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("wow that's awesome!");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zeland",
                "I'm going to visit this wonderful country",
                12);

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good Night!");
            Comment c4 = new Comment("May the force be with you!");

            Post p2 = new Post(
            DateTime.Parse("03/08/2018 14:34:50"),
            "Good night guys",
            "See you!",
            5);

            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}
