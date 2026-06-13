using System.Reflection.Metadata.Ecma335;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name,description,points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;

    }
public void MarkComplete()
{
    _isComplete = true;
}
    public override int GetPoints()
    {
        return int.Parse(_points);
    }

    public override string GetStringRepresentation()
    {
        string simpleString = ($"Simple goal|{_shortName}|{_description}|{_points}|{_isComplete}");
        return simpleString;
    }
}