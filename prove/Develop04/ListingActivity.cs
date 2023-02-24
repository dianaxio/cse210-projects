public class ListingActivity: Activity
{
    private int _itemCounter;
    public ListingActivity(string title, string description, int duration) : base(title,description,duration)
    {

    }
    public void ItemsInput(int random)
    {
        DisplayStartinMessage();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("\nList as many responses you can to the following prompt:\n --- ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        DisplayPrompt(random);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(" ---\n\nYou may begin in: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        CountDown(5);
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        _itemCounter = 0;
        do
        {
            Console.ReadLine();
            _itemCounter += 1;
            DateTime currentTime = DateTime.Now;
            if (currentTime >= futureTime)
            {
                break;
            }
        }while(true);
        DisplayItemsAmount();
        Record();
        DisplayEndingMessage();
    }

    public void DisplayItemsAmount()
    {   
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n__________________");
        Console.WriteLine("You listed {0} items!",_itemCounter);
        Console.WriteLine("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");

    }
}