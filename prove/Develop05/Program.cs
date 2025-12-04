using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        GoalManager goalManager = new GoalManager();
        
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine($"\nYou have {goalManager.GetTotalPoints()} points");
            choice = menu.DisplayMenu();

            switch (choice)
            {
                case 1:
                    CreateNewGoal(menu, goalManager);
                    break;
                    
                case 2:
                    goalManager.DisplayGoals();
                    break;
                    
                case 3:
                    SaveGoals(goalManager);
                    break;
                    
                case 4:
                    LoadGoals(goalManager);
                    break;
                    
                case 5:
                    RecordEvent(goalManager);
                    break;
                    
                case 6:
                    Console.WriteLine("Goodbye!");
                    break;
            }
        }
    }

    static void CreateNewGoal(Menu menu, GoalManager goalManager)
    {
        int goalType = menu.DisplayCreateGoalMenu();
        
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case 1:
                goalManager.AddGoal(new SimpleGoal(name, description, points));
                Console.WriteLine("Simple goal created successfully!");
                break;
                
            case 2:
                goalManager.AddGoal(new EternalGoal(name, description, points));
                Console.WriteLine("Eternal goal created successfully!");
                break;
                
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int targetCount = int.Parse(Console.ReadLine());
                
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonusPoints = int.Parse(Console.ReadLine());
                
                goalManager.AddGoal(new ChecklistGoal(name, description, points, bonusPoints, targetCount));
                Console.WriteLine("Checklist goal created successfully!");
                break;
                
            case 4:
                Console.Write("Enter deadline (yyyy-mm-dd): ");
                DateTime deadline = DateTime.Parse(Console.ReadLine());
                
                Console.Write("Early completion bonus per day (0 for none): ");
                int earlyBonus = int.Parse(Console.ReadLine());
                
                Console.Write("Late penalty per day (0 for none): ");
                int latePenalty = int.Parse(Console.ReadLine());
                
                goalManager.AddGoal(new DeadlineGoal(name, description, points, deadline, earlyBonus, latePenalty));
                Console.WriteLine("Deadline goal created successfully!");
                break;
        }
    }

    static void RecordEvent(GoalManager goalManager)
    {
        goalManager.DisplayGoals();
        
        if (goalManager.GetGoalCount() > 0)
        {
            Console.Write("Which goal did you accomplish? ");
            if (int.TryParse(Console.ReadLine(), out int goalNumber))
            {
                goalManager.RecordEvent(goalNumber - 1);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }

    static void SaveGoals(GoalManager goalManager)
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        goalManager.SaveGoals(filename);
        Console.WriteLine("Goals saved successfully!");
    }

    static void LoadGoals(GoalManager goalManager)
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        goalManager.LoadGoals(filename);
        Console.WriteLine("Goals loaded successfully!");
    }
}