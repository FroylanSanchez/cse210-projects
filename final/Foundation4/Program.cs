using System;
using System.Collections.Generic;

namespace Foundation4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            List<Activity> activities = new List<Activity>();

            Activity running = new Running("December 3, 2025", 35, 4.2);
            Activity cycling = new Cycling("December 7, 2025", 50, 18.5);
            Activity swimming = new Swimming("December 10, 2025", 40, 48);

            activities.Add(running);
            activities.Add(cycling);
            activities.Add(swimming);

            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
