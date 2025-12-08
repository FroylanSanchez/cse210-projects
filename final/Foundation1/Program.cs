class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        for (int i = 1; i <= 3; i++)
        {
            Video video = new Video();

            Console.Write($"Enter the title for video {i}: ");
            video.SetTitle(Console.ReadLine());

            Console.Write($"Enter the author for video {i}: ");
            video.SetAuthor(Console.ReadLine());

            Console.Write($"Enter the length (in minutes) for video {i}: ");
            video.SetLength(double.Parse(Console.ReadLine()));

            Console.WriteLine("\nNow enter 3 comments for this video:");

            for (int c = 1; c <= 3; c++)
            {
                Console.Write($"Name of commenter #{c}: ");
                string person = Console.ReadLine();

                Console.Write($"Comment #{c}: ");
                string text = Console.ReadLine();

                video.AddComment(new Comment(person, text));
            }

            videos.Add(video);
            Console.WriteLine("\n----------------------------------------\n");
        }

        Console.WriteLine("\nVIDEOS AND COMMENTS\n");

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
