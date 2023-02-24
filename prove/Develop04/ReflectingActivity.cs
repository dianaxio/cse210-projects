public class ReflectingActivity: Activity
{
    List<string> _questions = new List<string>();
    public ReflectingActivity(string title, string description, int duration) : base(title,description,duration)
    {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }
    public void DisplayQuestion(int random)
    {
        DisplayStartinMessage();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("\nConsider the following prompt:\n\n --- ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        DisplayPrompt(random);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(" ---\n\nWhen you have something in mind, press enter to continue.");
        Console.Read();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Now ponder on each of the following questions as they ralated to this experience.\nYou may begin in: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        CountDown(5);
        Console.Clear();
        int duration = _duration;
        while(duration > 0)
        {
            Random ran = new Random();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n" + _questions[ran.Next(0,9)] + " ");
            DisplayAnimation(5);
            duration = duration - 10;
        }
        Console.Write("\n");
        Record();
        DisplayEndingMessage();
    }
}