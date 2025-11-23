using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Start Grateful Activity");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            BaseActivity activity = choice switch
            {
                "1" => new Breathing(),
                "2" => new Reflecting(),
                "3" => new Listing(),
                "4" => new Grateful(),
                "5" => null,
                _ => null
            };

            if (activity == null)
                break;

            activity.Start();
        }
    }
}
