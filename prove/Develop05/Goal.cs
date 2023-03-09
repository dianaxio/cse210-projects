public abstract class Goal
{

    protected bool _complete;
    protected string _name;         
    protected string _description;
    protected int _points;
    protected int _type;

    public Goal(string name, string description, int points, bool complete)
    { 
        _name = name;
        _description = description;
        _points = points;
        _complete = complete;
    }

    public bool IsCompleted()
    {
        return _complete;
    }
    
    public abstract void SetComplete();

    public abstract void DisplayGoal(int option);

    public abstract string GetStringRepresentation();

    public int GetPoints()
    {
        return _points;
    }

}   