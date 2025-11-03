using System;

class Program
{
    static void Main(string[] args)
    {
        string keepPlaying = "yes";

        do
        {

            // Console.WriteLine("What is the magic number? ");
            // string mnText = Console.ReadLine();
            // int magicNumber = int.Parse(mnText);

            Random RandomGenerator = new Random();
            int magicNumber = RandomGenerator.Next(1, 101);
            int guessNumber = -1;
            int count = 0;

            while (magicNumber != guessNumber)
            {
                count = count + 1;
                Console.WriteLine("What is your guess? ");
                string guess = Console.ReadLine();
                guessNumber = int.Parse(guess);

                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }

                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }

                else
                {
                    Console.WriteLine("You guessed it! It only took you " + count + " attempts.");
                }

            }

        Console.WriteLine("Do you want to keep playing?");
        keepPlaying = Console.ReadLine();

        } while (keepPlaying == "yes");

        }
}