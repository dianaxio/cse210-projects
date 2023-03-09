public class SimpleGoal : Goal
{

    public SimpleGoal(string name, string description, int points, bool complete)
    : base (name,description,points,complete)
    {
        _type = 1;
    }
    
    public override void SetComplete()
    {
        _complete = true;
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
            Console.WriteLine($" {_name} ({_description})");
        }
        else
        {
            Console.WriteLine($"{_name}");         
        }
    }

    public override string GetStringRepresentation()
    {
        return $"{_type},{_name},{_description},{_points},{_complete}";
    }
}