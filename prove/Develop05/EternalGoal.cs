public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, int points)
    : base (name,description,points,false)
    {
        _type = 2;
    }
    
    public override void SetComplete()
    {
        _complete = false;
        Console.WriteLine($"Congratulations! You have earned {_points} points\n");
    }

    public override void DisplayGoal(int option)
    {
        if (option == 0) Console.WriteLine($"[ ] {_name} ({_description})");
        else
        {
            Console.WriteLine($"{_name}");         
        }
    }
    public override string GetStringRepresentation()
    {
        return $"{_type},{_name},{_description},{_points}";
    }
}