public class Activity
{

    protected string _title;
    protected string _description;
    protected int _duration;
    private List<string> _prompts = new List<string>();

    private int milliseconds = 125;
    
    public Activity()
    {

    }

    public Activity(string title, string description, int duration)
    {
        _title = title;
        _description = description;
        _duration = duration;

        if(_title.Equals("Breathing"))
        {
            _prompts.Add("Breathe in...");
            _prompts.Add("Now breathe out...");

        }
        else if(_title.Equals("Reflecting"))
        {
            _prompts.Add("Think of a time when you stood up for someone else.");
            _prompts.Add("Think of a time when you did something really difficult.");
            _prompts.Add("Think of a time when you helped someone in need.");
            _prompts.Add("Think of a time when you did something truly selfless.");
        }
        else if(_title.Equals("Listing"))
        {
            _prompts.Add("Who are people that you appreciate?");
            _prompts.Add("What are personal strengths of yours?");
            _prompts.Add("Who are people that you have helped this week?");
            _prompts.Add("When have you felt the Holy Ghost this month?");
            _prompts.Add("Who are some of your personal heroes?");
        }
    }

    public void SeeRecords()
    {
        Console.Clear();
        StreamReader sr = new StreamReader("Records.txt");
        List<string[]> lines = new List<string[]>();
        for(int i = 0; i < 3; i ++)
        {
            lines.Add(sr.ReadLine().Split(','));
        }
        sr.Close();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\nBreathing Activity:\nTimes Done: {lines[0][0]}\nTotal Time: {lines[0][1]}\n");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Reflecting Activity:\nTimes Done: {lines[1][0]}\nTotal Time: {lines[1][1]}\n");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"Listing Activity:\nTimes Done: {lines[2][0]}\nTotal Time: {lines[2][1]}\n");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"Press Enter to Go to the Menu");
        Console.ReadLine();
    }

    public void Record()
    {
        StreamReader sr = new StreamReader("Records.txt");
        List<string[]> lines = new List<string[]>();
        for(int i = 0; i < 3; i ++)
        {
            lines.Add(sr.ReadLine().Split(','));
        }
        sr.Close();

        StreamWriter sw = new StreamWriter("Records.txt");

        if(_title.Equals("Breathing"))
        {
            sw.WriteLine($"{int.Parse(lines[0][0]) + 1},{int.Parse(lines[0][1]) + _duration}");
            sw.WriteLine($"{lines[1][0]},{lines[1][1]}");
            sw.WriteLine($"{lines[2][0]},{lines[2][1]}");
        }
        else if(_title.Equals("Reflecting"))
        {
            sw.WriteLine($"{lines[0][0]},{lines[0][1]}");
            sw.WriteLine($"{int.Parse(lines[1][0]) + 1},{int.Parse(lines[1][1]) + _duration}");
            sw.WriteLine($"{lines[2][0]},{lines[2][1]}");
        }
        else if(_title.Equals("Listing"))
        {
            sw.WriteLine($"{lines[0][0]},{lines[0][1]}");
            sw.WriteLine($"{lines[1][0]},{lines[1][1]}");
            sw.WriteLine($"{int.Parse(lines[2][0]) + 1},{int.Parse(lines[2][1]) + _duration}");
        }
        sw.Close();
    }

    public void DisplayStartinMessage()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n--------------------------------------");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"|  Welcome to the {_title} Activity  |");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("--------------------------------------\n");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(_description + "\n");
        SetDuration();
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Get Ready...");
        DisplayAnimation(2);
    }

    public void DisplayEndingMessage()
    {   
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\nWell Done!!");
        DisplayAnimation(1);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("__________________________________________________________________");
        Console.WriteLine($"| You have compleated another {_duration} seconds of the {_title} Activity|");
        Console.WriteLine("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
        DisplayAnimation(2);
        Console.Clear();
    }

    public void DisplayAnimation(float seconds)
    {
            float timeRemaining = seconds;

            while (timeRemaining >= 0)
            {   
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\b \b/");
                Thread.Sleep(milliseconds);
                Console.Write("\b \b—");
                Thread.Sleep(milliseconds);
                Console.Write("\b \b\\");
                Thread.Sleep(milliseconds);
                Console.Write("\b \b|");
                Thread.Sleep(milliseconds);
                timeRemaining -= 0.5f;
            }
            Console.Write("\b \b");
        }

   public void CountDown(int time)
    {
        for(int i = time; i > 0; i --)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void DisplayPrompt(int promptIndex)
    {
        Console.Write(_prompts[promptIndex]);
    }

    private void SetDuration()
    {
        do
        {   
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"How long, in seconds, would you like for your session?: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            _duration = int.Parse(Console.ReadLine());
            if(_duration%10!=0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"For a better experience it is requiered that you introduce a multiple of 10 time in seconds. Please do it again. ");
                DisplayAnimation(2);         
                Console.WriteLine();       
            }
            else
            {
                break;
            }
        }
        while(true);
    }

}