public class ChecklistGoal : Goal
{
    private int _amountCompleted;

    private int _target;

    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus): base(name,description,points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted += 1;
    }

    public override bool IsComplete()
    {
        if (_amountCompleted < _target)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public override int GetPoints()
    {
        int points = int.Parse(_points);

        if (_amountCompleted == _target)
        {
            points += _bonus;
        }
        return points;
    }
    public void SetProgress(int completed)
{
    _amountCompleted = completed;
}

    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            
           return $"[X] {_shortName} ({_description}) --{_amountCompleted}/{_target}";
        }
        else
        {
             return $"[ ] {_shortName} ({_description}) --{_amountCompleted}/{_target}";
            
        }
    }
    

    public override string GetStringRepresentation()
    {
        string checkListString = ($"Checklist Goal|{_shortName}|{_description}|{_points}|{_bonus}|Completed{_amountCompleted}/{_target} times.");
        return checkListString;
    }

}