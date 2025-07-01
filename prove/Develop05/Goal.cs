// Goal.cs

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _numberofPoints;
    protected bool _status;
    protected string _goalType;

    public Goal(string name, string description, int points, bool status)
    {
        _name = name;
        _description = description;
        _numberofPoints = points;
        _status = status;
    }

    public Goal()
    {

    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPoints()
    {
        return _numberofPoints;
    }

    public void SetPoints(int points)
    {
        _numberofPoints = points;
    }

    public bool GetStatus()
    {
        return _status;
    }

    public void SetStatus(bool status)
    {
        _status = status;
    }

    public int MarkComplete()
    {
        _status = true;
        return _numberofPoints;
    }

    public virtual string GetGoalType()
    {
        return _goalType;
    }

    public virtual string ListGoal()
    {
        string checkbox = _status ? "[X]" : "[ ]";
        return $"{checkbox} {_name} ({_description})";
    }

    public override string ToString()
    {
        return $"{_goalType}|{_name}|{_description}|{_numberofPoints}|{_status}";
    }

    public abstract int RecordEvent();


    public abstract void RunGoal();


}