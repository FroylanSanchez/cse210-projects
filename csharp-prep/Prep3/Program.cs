using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine("What is the magic number? ");
        string mn_text = Console.ReadLine();
        int magic_number = int.Parse(mn_text);

        do
        {
            Console.WriteLine("What is your guess? ");
            string guess = Console.ReadLine();
            int guess_number = int.Parse(guess);
        } while (guess_number = magic_number);
        if 


    }
}