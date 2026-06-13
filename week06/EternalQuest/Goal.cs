public abstract class  Goal
{
    protected string _shortName;

    protected string _description;

    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    

    public abstract bool IsComplete();
  

    public virtual string GetDetailsString() 
    {
        if (IsComplete())
        {
            
        string details = ($"[X] {_shortName} ({_description})");
        return details;
        }
        else
        {
            string details = ($"[ ] {_shortName} ({_description})");
            return details;
        }
    }

    public abstract string GetStringRepresentation();

    public virtual int GetPoints()
    {
        return int.Parse(_points);
    }
}