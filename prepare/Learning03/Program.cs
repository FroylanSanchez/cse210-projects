using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.FractionPrint());
        Console.WriteLine(f1.FractionDecimal());
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.FractionPrint());
        Console.WriteLine(f2.FractionDecimal());
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.FractionPrint());
        Console.WriteLine(f3.FractionDecimal());

    }
}