/*  For Showing Creativity and Exceeding Requirements:
    I added the option to create negative goals. 
    The user loses points for bad habits.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        bool clear = true;
        bool flag = true;
        Console.Clear();
        Console.Write("Please write your username: ");
        User user = new User(Console.ReadLine());
        do
        {
            if (clear) Console.Clear();
            else clear = true;
            Console.Write($"{user.GetUsername()}, you have {user.GetTotalPoints()} points.\n\nMenu Options:\n   1. Create New Goal\n   2. List Goals\n   3. Save Goals\n   4. Load Goals\n   5. Record Event\n   6. Quit\nSelect a choice from the menu: ");
            string option = Console.ReadLine();
            switch(option)
            {
                case "1":
                    user.CreateNewGoal();
                    break;

                case "2":
                    Console.Clear();
                    user.DisplayGoals();
                    clear = false;
                    break;

                case "3":
                    user.Save();
                    break;


                case "4":
                    user.Load();
                    break;

                case "5":
                Console.Clear();
                    user.RecordEvent();
                    clear = false;
                    break;

                case "6":
                    flag = false;
                    break;

                default:
                    Console.WriteLine("No available option. Pleas try again.");
                    Thread.Sleep(1200);
                    break;
            }
        }
        while(flag);
    }
}