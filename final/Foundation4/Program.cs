using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Activity> activities =  new List<Activity>();
        activities.Add(new Running("03 Nov 2022",4.8,30));
        activities.Add(new Cycling("05 Nov 2022",9.6,30));
        activities.Add(new Swimming("08 Nov 2022",96,30));
        int i = 1;
        foreach(Activity activity in activities)
        {
            Console.WriteLine($"\nFor activity number {i}:\n{activity.GetSummary()}");
            i++;
        }
        Console.WriteLine();
    }
}