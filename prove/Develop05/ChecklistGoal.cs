public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _targetCount;
    private int _currentCount;

    public ChecklistGoal(string name, string description, int points, int bonusPoints, int targetCount) 
        : base(name, description, points)
    {
        _bonusPoints = bonusPoints;
        _targetCount = targetCount;
        _currentCount = 0;
    }

    public ChecklistGoal(string name, string description, int points, int bonusPoints, int targetCount, int currentCount) 
        : base(name, description, points)
    {
        _bonusPoints = bonusPoints;
        _targetCount = targetCount;
        _currentCount = currentCount;
        _isComplete = currentCount >= targetCount;
    }

    public override void RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            if (_currentCount >= _targetCount)
            {
                _isComplete = true;
            }
        }
    }

    public override bool IsComplete() => _isComplete;

    public int GetBonusPoints()
    {
        if (IsComplete())
        {
            return _bonusPoints;
        }
        return 0;
    }

    public override string GetDetailsString()
    {
        return $"Checklist Goal: {_name}\nDescription: {_description}\nPoints per completion: {_points}\nBonus points: {_bonusPoints}\nCompleted: {_currentCount}/{_targetCount}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_bonusPoints},{_targetCount},{_currentCount}";
    }

    public override string GetConsoleString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {_name} ({_description}) -- Currently completed: {_currentCount}/{_targetCount}";
    }
}