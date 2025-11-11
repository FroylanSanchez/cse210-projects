using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello Sandbox World!");
        Circle myCircle = new Circle();
        //myCircle._radius = -10;
        myCircle._radius = 10;
        Console.WriteLine(myCircle.GetCircleArea());


    }
}