using System;

namespace FoundationManager
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("CSE 210 Foundation Project Manager");
                Console.WriteLine("1. Foundation 1");
                Console.WriteLine("2. Foundation 2");
                Console.WriteLine("3. Foundation 3");
                Console.WriteLine("4. Foundation 4");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        Foundation1.Program.Run();
                        break;
                    case "2":
                        Foundation2.Program.Run();
                        break;
                    case "3":
                        Foundation3.Program.Run();
                        break;
                    case "4":
                        Foundation4.Program.Run();
                        break;
                    case "5":
                        return;
                }

                Console.WriteLine("\nPress ENTER to return to the menu");
                Console.ReadLine();
            }
        }
    }
}
