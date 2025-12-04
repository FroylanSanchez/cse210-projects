using System;

public class DeadlineGoal : Goal
{
    private DateTime _deadline;
    private DateTime? _completionDate;
    private int _earlyBonus;
    private int _latePenalty;

    public DeadlineGoal(string name, string description, int points, 
                       DateTime deadline, int earlyBonus = 0, int latePenalty = 0) 
        : base(name, description, points)
    {
        _deadline = deadline;
        _earlyBonus = earlyBonus;
        _latePenalty = latePenalty;
        _completionDate = null;
    }

    public DeadlineGoal(string name, string description, int points, 
                       DateTime deadline, DateTime? completionDate, 
                       int earlyBonus, int latePenalty) 
        : base(name, description, points)
    {
        _deadline = deadline;
        _completionDate = completionDate;
        _earlyBonus = earlyBonus;
        _latePenalty = latePenalty;
        _isComplete = completionDate.HasValue;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _completionDate = DateTime.Now;
            _isComplete = true;
        }
    }

    public override bool IsComplete() => _isComplete;

    public int CalculateBonusPenalty()
    {
        if (!_completionDate.HasValue || !_isComplete)
            return 0;

        if (_completionDate.Value <= _deadline)
        {
            TimeSpan timeLeft = _deadline - _completionDate.Value;
            
            if (timeLeft.TotalDays > 0 && _earlyBonus > 0)
            {
                int daysEarly = (int)timeLeft.TotalDays;
                int bonus = Math.Min(_earlyBonus * daysEarly, _earlyBonus * 7);
                Console.WriteLine($"⏰ Early completion! +{bonus} bonus points!");
                return bonus;
            }
            return 0;
        }
        else
        {
            if (_latePenalty > 0)
            {
                TimeSpan timeLate = _completionDate.Value - _deadline;
                int daysLate = (int)timeLate.TotalDays;
                int penalty = Math.Min(_latePenalty * daysLate, _latePenalty * 7);
                Console.WriteLine($"⚠️  Late completion! -{penalty} penalty points!");
                return -penalty;
            }
            return 0;
        }
    }

    public string GetDeadlineStatus()
    {
        if (_isComplete)
        {
            if (_completionDate <= _deadline)
                return "Completed early/on time!";
            else
                return "Completed late";
        }
        else
        {
            TimeSpan timeRemaining = _deadline - DateTime.Now;
            if (timeRemaining.TotalDays < 0)
                return $"OVERDUE by {(int)-timeRemaining.TotalDays} days!";
            else if (timeRemaining.TotalDays < 1)
                return $"Due today! ({timeRemaining.Hours}h {timeRemaining.Minutes}m remaining)";
            else if (timeRemaining.TotalDays < 7)
                return $"Due in {(int)timeRemaining.TotalDays} days";
            else
                return $"Due on {_deadline:MMM dd, yyyy}";
        }
    }

    public override string GetDetailsString()
    {
        string status = GetDeadlineStatus();
        string bonusInfo = _earlyBonus > 0 ? $"\nEarly bonus: {_earlyBonus} points/day (max 7 days)" : "";
        string penaltyInfo = _latePenalty > 0 ? $"\nLate penalty: {_latePenalty} points/day (max 7 days)" : "";
        
        return $"Deadline Goal: {_name}\nDescription: {_description}\nPoints: {_points}\nDeadline: {_deadline:MMM dd, yyyy}\nStatus: {status}" + bonusInfo + penaltyInfo;
    }

    public override string GetStringRepresentation()
    {
        string completionDateStr = _completionDate?.ToString("yyyy-MM-ddTHH:mm:ss") ?? "";
        return $"DeadlineGoal:{_name},{_description},{_points}," +
               $"{_deadline:yyyy-MM-dd},{completionDateStr},{_earlyBonus},{_latePenalty}";
    }

    public override string GetConsoleString()
    {
        string icon = _isComplete ? "✓" : "⏰";
        string status = GetDeadlineStatus();
        
        if (!_isComplete)
        {
            TimeSpan timeLeft = _deadline - DateTime.Now;
            if (timeLeft.TotalDays < 0)
                icon = "⚠️";
            else if (timeLeft.TotalDays < 3)
                icon = "🔥";
        }
        
        return $"[{icon}] {_name} - {status}";
    }
}