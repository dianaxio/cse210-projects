public class SimpleNegativeGoal : Goal
{

    public SimpleNegativeGoal(string name, string description, int points, bool complete)
    : base (name,description,points,complete)
    {
        _type = 4;
    }
    
    public override void SetComplete()
    {
        _complete = true;
        Console.WriteLine($"Oh no... You have lost {_points} points\n");
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
            Console.WriteLine($" {_name} ({_description}) - This is a negative goal");
        }
        else
        {
            Console.WriteLine($"{_name} - This is a negative goal");         
        }
    }

    public override string GetStringRepresentation()
    {
        return $"{_type},{_name},{_description},{_points},{_complete}";
    }
}