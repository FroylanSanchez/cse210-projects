using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address(
            "Tepeyollotl Mz 2 Lt 8",
            "Ecatepec de Morelos",
            "Mexico",
            "Mexico"
        );

        Event lecture = new Lecture(
            "Faith, Education, and Lifelong Learning",
            "A discussion on how faith in Jesus Christ and education work together to prepare individuals for lifelong service, leadership, and personal growth.",
            "April 15, 2024",
            "7:00 – 8:30 P.M.",
            address,
            "Elder Dieter F. Uchtdorf",
            300,
            185
        );

        Event reception = new Reception(
            "Shantell and Froylan's Wedding",
            "Wedding celebration at the Mesa Ward church building",
            "April 11",
            "4:30 P.M.",
            address,
            "san24112@byui.edu"
        );

        Event outdoor = new Outdoor(
            "Soccer Championship",
            "Stake Soccer Championship",
            "March 25",
            "5:00 P.M.",
            address,
            "Sunny"
        );

        DisplayEvent(lecture);
        DisplayEvent(reception);
        DisplayEvent(outdoor);
    }

    static void DisplayEvent(Event e)
    {
        Console.WriteLine("FULL DETAILS");
        Console.WriteLine(e.GetFullDetails());
        Console.WriteLine("\nSTANDARD DETAILS");
        Console.WriteLine(e.GetStandardDetails());
        Console.WriteLine("\nSHORT DETAILS");
        Console.WriteLine(e.GetShortDetails());
        Console.WriteLine("\n---------------------------\n");
    }
}
