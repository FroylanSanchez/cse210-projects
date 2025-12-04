using System;

public class Menu
{
    public int DisplayMenu()
    {
        int response = 0;

        while(response < 1 || response > 6) 
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine(" 1. Create Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");

            try
            {
                response = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Input must be an integer value between 1 and 6.");
            }
        }
        return response;
    }

    public int DisplayCreateGoalMenu()
    {
        int response = 0;
        
        while(response < 1 || response > 4)
        {
            Console.WriteLine("\nThe types of goals are:");
            Console.WriteLine(" 1. Simple Goal");
            Console.WriteLine(" 2. Eternal Goal");
            Console.WriteLine(" 3. Checklist Goal");
            Console.WriteLine(" 4. Deadline Goal");
            Console.Write("Which type of goal would you like to create? ");
            
            try
            {
                response = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter 1, 2, 3, or 4.");
            }
        }
        return response;
    }
}