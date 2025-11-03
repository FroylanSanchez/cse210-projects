using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 1;

        do
        {
            Console.Write("Enter number: ");
            string snumber = Console.ReadLine();
            number = int.Parse(snumber);
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        int sum = numbers.Sum();
        Console.WriteLine(sum);

        double average = numbers.Average();
        Console.WriteLine(average);

        int max = numbers.Max();
        Console.WriteLine(max);
        
    }
    
    
}