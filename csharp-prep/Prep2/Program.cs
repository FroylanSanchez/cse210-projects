using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your grade? ");
        string grade = Console.ReadLine();
        int grade_number = int.Parse(grade);

        if (grade_number >= 90)
        {
            Console.WriteLine("Your grade is A");
        }
        else if (grade_number >= 80)
        {
            Console.Write("Your grade is B ");
        }

        else if (grade_number >= 70)
        {
            Console.Write("Your grade is C ");
        }

        else if (grade_number >= 60)
        {
            Console.Write("Your grade is D ");
        }

        else if (grade_number < 60)
        {
            Console.Write("Your grade is F ");
        }

        if (grade_number >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }

        else if (grade_number < 70)
        {
            Console.WriteLine("Sorry, you failed, better luck next time.");
        }

    }
}