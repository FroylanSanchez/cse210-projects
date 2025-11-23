using System;
using System.Threading;

class BaseActivity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session? ");

        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner(3);

        ExecuteActivity();

        Console.WriteLine("\nWell done!!");
        Spinner(2);

        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        Spinner(3);
    }

    protected void Spinner(int seconds)
    {
        string[] icons = { "|", "/", "-", "\\" };

        DateTime end = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < end)
        {
            Console.Write(icons[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i = (i + 1) % icons.Length;
        }

        Console.WriteLine();
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    protected virtual void ExecuteActivity()
    {
    }
}
