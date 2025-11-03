using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();
        string userName = AskName();
        int userNumber = AskNumber();
        int numnum = SquareNumber(userNumber);
        int year = AskBirthYear();
        DisplayProgram(userName, numnum, year);

    }
    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string AskName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int AskNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string snumber = Console.ReadLine();
        int number = int.Parse(snumber);
        return number;
    }
    static int AskBirthYear()
    {
        Console.Write("Please enter the year you were born: ");
        string syear = Console.ReadLine();
        int year = int.Parse(syear);
        return year;
    }

    static int SquareNumber(int number)
    {
        int sqnumber = number * number;
        return sqnumber;

    }
    
    static void DisplayProgram(string name, int sqnumber, int year)
    {
        Console.WriteLine($"{name}, the square of your number is {sqnumber}.");
        Console.WriteLine($"{name}, you will turn {2025 - year} years old this year.");
    }

}
