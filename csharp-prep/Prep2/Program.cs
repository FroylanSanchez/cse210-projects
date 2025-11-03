using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your grade? ");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);

        if (gradeNumber >= 90)
        {
            Console.WriteLine("Your grade is A");
        }
        else if (gradeNumber >= 80)
        {
            Console.Write("Your grade is B ");
        }

        else if (gradeNumber >= 70)
        {
            Console.Write("Your grade is C ");
        }

        else if (gradeNumber >= 60)
        {
            Console.Write("Your grade is D ");
        }

        else if (gradeNumber < 60)
        {
            Console.Write("Your grade is F ");
        }

        if (gradeNumber >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }

        else if (gradeNumber < 70)
        {
            Console.WriteLine("Sorry, you failed, better luck next time.");
        }

    }
}