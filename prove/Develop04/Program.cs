/* 
I added Console.ForegroundColor to improve 
the readability of the program and to make 
the code look more attractive and professional

Exceeding Requirements: 
I added the possibility to see the records, and 
I created a file where the records are stored.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Activity spinner = new Activity();
        Random random = new Random();
        bool flag = true;
        do
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n\tMenu Options:\n\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("   1. Start breathing activity\n   2. Start reflecting activity\n   3. Start listing activity\n   4. See Records\n   5. Quit\n\nSelect a choice from the menu:\n>> ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string option = Console.ReadLine();
            switch(option)
            {
                case "1":
                    BreathingActivity ba = new BreathingActivity("Breathing","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",0);
                    ba.DisplayBreathingCycle();
                    break;

                case "2":
                    ReflectingActivity ra = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);
                    ra.DisplayQuestion(random.Next(0,4));
                    Console.ReadLine(); // clears the buffer
                    break;

                case "3":
                    ListingActivity la = new ListingActivity("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",0);
                    la.ItemsInput(random.Next(0,5));
                    break;

                case "4":
                    spinner.SeeRecords();
                    break;

                case "5":
                    flag = false;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("_________________________________");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" Thank you for using our program");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nSorry, that is not a valid choice.\n");
                    spinner.DisplayAnimation(2);
                    break;
            }
        }
        while(flag);

    }
}