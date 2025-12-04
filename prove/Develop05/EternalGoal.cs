public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        // Eternal goals never get marked complete
        // Just record that it was done
    }

    public override bool IsComplete() => false; // Never complete

    public override string GetDetailsString()
    {
        return $"Eternal Goal: {_name}\nDescription: {_description}\nPoints per completion: {_points}";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_name},{_description},{_points}";
    }

    public override string GetConsoleString()
    {
        return $"[∞] {_name} ({_description})";
    }
}