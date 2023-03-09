public class CheckListGoal : Goal
{
    private int _bonusPoints;
    private int _timeForBonus;
    private int _timesDone;

    public CheckListGoal(string name, string description, int points, int bonusPoints, int timeForBonus, int timesDone, bool complete)
    : base (name,description,points,complete)
    {
        _type = 3;
        _timesDone = timesDone;
        _bonusPoints = bonusPoints;
        _timeForBonus = timeForBonus;
    }
    
    public override void SetComplete()
    {
        _timesDone += 1;
        if(_timeForBonus == _timesDone)
        {
            _complete = true;
            _points += _bonusPoints;
        }
        Console.WriteLine($"Congratulations! You have earned {_points} points\n");
    }

    public override void DisplayGoal(int option)
    {
        if(option == 0)
        {
            if(IsCompleted())
            {
                Console.Write("[X]");
            }
            else
            {
                Console.Write("[ ]");
            }
            Console.WriteLine($" {_name} ({_description}) -- Currently completed: {_timesDone}/{_timeForBonus}");
        }
        else
        {
            Console.WriteLine($"{_name}");         
        }
    }
    public override string GetStringRepresentation()
    {
        return $"{_type},{_name},{_description},{_points},{_bonusPoints},{_timeForBonus},{_timesDone},{_complete}";
    }
}