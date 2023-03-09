public class User
{
    private string _name;
    private List<Goal> _goals;
    private int _totalPoints;

    public User(string name)
    {
        _name = name;
        _goals = new List<Goal>();
    }

    public string GetUsername()
    {
        return _name;
    }

    public void DisplayGoals()
    {
        int i = 1;
        foreach(Goal goal in _goals)
        {
            Console.Write(i + ". ");
            goal.DisplayGoal(0);
            i++;
        }
        Console.WriteLine();
    }

    public void UpdatePoints(int newPoints)
    {
        _totalPoints += newPoints;
    }

    public void Save()
    {
        Console.Clear();
        Console.Write("Please Introduce the Filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_totalPoints);
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void Load()
    {
        Console.Clear();
        Console.Write("Please Introduce the Filename: ");
        string filename = Console.ReadLine();
        bool first = true;
        string[] lines = System.IO.File.ReadAllLines(filename);
        _goals.Clear();
        foreach (string line in lines)
        {
            if(first)
            {
                _totalPoints = int.Parse(line);
                first = false;
                continue;
            }
            string[] parts = line.Split(",");
            if(int.Parse(parts[0]) == 1)
            {
                bool complete;
                if(parts[4].ToLower().Equals("true"))
                {
                    complete = true;
                }
                else
                {
                    complete = false;
                }
                SimpleGoal newGoal = new SimpleGoal(parts[1],parts[2],int.Parse(parts[3]),complete);
                _goals.Add(newGoal);
            }
            else if(int.Parse(parts[0]) == 2)
            {
                EternalGoal newGoal = new EternalGoal(parts[1],parts[2],int.Parse(parts[3]));
                 _goals.Add(newGoal);
            }
            else if(int.Parse(parts[0]) == 3)
            {
                bool complete;
                if(parts[7].ToLower().Equals("true"))
                {
                    complete = true;
                }
                else
                {
                    complete = false;
                }
                CheckListGoal newGoal = new CheckListGoal(parts[1],parts[2],int.Parse(parts[3]),int.Parse(parts[4]),int.Parse(parts[5]),int.Parse(parts[6]),complete);
                _goals.Add(newGoal);
            }
            else if(int.Parse(parts[0]) == 4)
            {
                bool complete;
                if(parts[4].ToLower().Equals("true"))
                {
                    complete = true;
                }
                else
                {
                    complete = false;
                }
                SimpleNegativeGoal newGoal = new SimpleNegativeGoal(parts[1],parts[2],int.Parse(parts[3]),complete);
                _goals.Add(newGoal);
            }
        }

    }

    public void CreateNewGoal()
    {
        Console.Clear();
        Console.Write("The types of Goals are:\n    1. Simple Goal\n    2. Eternal Goal\n    3. Checklist Goal\n    4. Simple Negative Goal\nWhich type of goal would you like to create?: ");
        int goalType = int.Parse(Console.ReadLine());

        if(goalType == 1)
        {
            Console.Write("What is the name of the goal?: ");
            string goalName = Console.ReadLine();
            Console.Write("What is short description of it?: ");
            string goalDescription = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal?: ");
            int goalPoints = int.Parse(Console.ReadLine());
            SimpleGoal goal = new SimpleGoal(goalName,goalDescription,goalPoints,false);
            _goals.Add(goal);
        }
        else if(goalType == 2)
        {
            Console.Write("What is the name of the goal?: ");
            string goalName = Console.ReadLine();
            Console.Write("What is short description of it?: ");
            string goalDescription = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal?: ");
            int goalPoints = int.Parse(Console.ReadLine());
            EternalGoal goal = new EternalGoal(goalName,goalDescription,goalPoints);
            _goals.Add(goal);
        }
        else if(goalType == 3)
        {
            Console.Write("What is the name of the goal?: ");
            string goalName = Console.ReadLine();
            Console.Write("What is short description of it?: ");
            string goalDescription = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal?: ");
            int goalPoints = int.Parse(Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplished for a bonus?: ");
            int timeForBonus = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times?: ");
            int bonusPoints = int.Parse(Console.ReadLine());
            CheckListGoal goal = new CheckListGoal(goalName,goalDescription,goalPoints,bonusPoints,timeForBonus,0,false);
            _goals.Add(goal);
        }
        else if(goalType == 4)
        {
            Console.Write("What is the name of the goal?: ");
            string goalName = Console.ReadLine();
            Console.Write("What is short description of it?: ");
            string goalDescription = Console.ReadLine();
            Console.Write("What is the amount of points to lose associated with this goal?: ");
            int goalPoints = int.Parse(Console.ReadLine());
            if(goalPoints>=0)
            {
                goalPoints *= -1;
            }
            SimpleNegativeGoal goal = new SimpleNegativeGoal(goalName,goalDescription,goalPoints,false);
            _goals.Add(goal);
        }
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public void RecordEvent()
    {
        int i = 1;
        List<Goal> goals_aux =  new List<Goal>();
        foreach(Goal goal in _goals)
        {
            if(!goal.IsCompleted())
            {
                goals_aux.Add(goal);
                Console.Write(i + ". ");
                goal.DisplayGoal(1);
                i++;
            }
        }
        if(i > 1)
        {
            Console.WriteLine("Which goal did you accomplish? (write the number): ");
            int index = int.Parse(Console.ReadLine()) - 1;
            goals_aux[index].SetComplete();   
            _totalPoints += goals_aux[index].GetPoints();  
        }
        else
        {
            Console.WriteLine("There are not goals to record\n");
        }
    }
    
}