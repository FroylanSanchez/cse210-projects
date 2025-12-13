using System;
using System.Collections.Generic;

namespace Foundation1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            List<Video> videos = new List<Video>();

            Video v1 = new Video();
            v1.SetTitle("Introduction to C#");
            v1.SetAuthor("John Doe");
            v1.SetLength(12.5);
            v1.AddComment(new Comment("Alice", "Very helpful video"));
            v1.AddComment(new Comment("Bob", "Clear explanation"));
            v1.AddComment(new Comment("Carlos", "Great examples"));

            Video v2 = new Video();
            v2.SetTitle("Object-Oriented Programming");
            v2.SetAuthor("Jane Smith");
            v2.SetLength(18.2);
            v2.AddComment(new Comment("Maria", "Loved the breakdown"));
            v2.AddComment(new Comment("Luis", "Easy to understand"));
            v2.AddComment(new Comment("Sofia", "Well explained"));

            Video v3 = new Video();
            v3.SetTitle("Abstraction in Practice");
            v3.SetAuthor("Emily Johnson");
            v3.SetLength(15.0);
            v3.AddComment(new Comment("Daniel", "Good real-world examples"));
            v3.AddComment(new Comment("Ana", "Helped me a lot"));
            v3.AddComment(new Comment("Kevin", "Nice pacing"));

            videos.Add(v1);
            videos.Add(v2);
            videos.Add(v3);

            int index = 1;

            foreach (Video v in videos)
            {
                Console.WriteLine($"Video {index}:");
                Console.WriteLine($"Title: {v.GetTitle()}");
                Console.WriteLine($"Author: {v.GetAuthor()}");
                Console.WriteLine($"Length: {v.GetLength()} minutes");
                Console.WriteLine($"Number of comments: {v.GetCommentCount()}");
                Console.WriteLine("Comments:");

                foreach (Comment c in v.GetComments())
                {
                    Console.WriteLine($"{c.GetName()} says: {c.GetContent()}");
                }

                Console.WriteLine("\n----------------------------------------\n");
                index++;
            }
        }
    }
}
