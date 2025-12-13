using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints = 0;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal goal = _goals[goalIndex];
            goal.RecordEvent();
            
            _totalPoints += goal.GetPoints();
            
            if (goal is ChecklistGoal checklistGoal)
            {
                int bonus = checklistGoal.GetBonusPoints();
                if (bonus > 0)
                {
                    _totalPoints += bonus;
                    Console.WriteLine($"🎉 Bonus awarded! +{bonus} points!");
                }
            }
            
            if (goal is DeadlineGoal deadlineGoal)
            {
                int adjustment = deadlineGoal.CalculateBonusPenalty();
                _totalPoints += adjustment;
            }
            
            if (goal.IsComplete())
            {
                Console.WriteLine($"Congratulations! You completed: {goal.GetName()}");
            }
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nYour Goals:");
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals yet. Create some!");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetConsoleString()}");
        }
        Console.WriteLine($"\nTotal Points: {_totalPoints}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_totalPoints);
            
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        
        _totalPoints = int.Parse(lines[0]);
        
        _goals.Clear();
        
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':', 2);
            string goalType = parts[0];
            string[] data = parts[1].Split(',');

            switch (goalType)
            {
                case "SimpleGoal":
                    SimpleGoal simpleGoal = new SimpleGoal(
                        data[0], data[1], int.Parse(data[2]), bool.Parse(data[3]));
                    _goals.Add(simpleGoal);
                    break;
                    
                case "EternalGoal":
                    EternalGoal eternalGoal = new EternalGoal(
                        data[0], data[1], int.Parse(data[2]));
                    _goals.Add(eternalGoal);
                    break;
                    
                case "ChecklistGoal":
                    ChecklistGoal checklistGoal = new ChecklistGoal(
                        data[0], data[1], int.Parse(data[2]), 
                        int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5]));
                    _goals.Add(checklistGoal);
                    break;
                    
                case "DeadlineGoal":
                    DateTime deadline = DateTime.Parse(data[3]);
                    DateTime? completionDate = string.IsNullOrEmpty(data[4]) ? 
                        null : (DateTime?)DateTime.Parse(data[4]);
                    DeadlineGoal deadlineGoal = new DeadlineGoal(
                        data[0], data[1], int.Parse(data[2]), deadline, 
                        completionDate, int.Parse(data[5]), int.Parse(data[6]));
                    _goals.Add(deadlineGoal);
                    break;
            }
        }
    }

    public int GetTotalPoints() => _totalPoints;
    public int GetGoalCount() => _goals.Count;
}