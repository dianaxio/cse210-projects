using System;

namespace Prep3
{
    class Program
    {
        static void Main(string[] args)
        {   
            // For Parts 1 and 2, where the user specified the number...
            // Console.Write("What is the magic number? ");
            // int magicNumber = int.Parse(Console.ReadLine());
            
            // For Part 3, where we use a random number
            Console.Clear();
            Random randomGenerator = new Random();
            bool a = true;
            
            // We could also use a do-while loop here...

            while (a) {
                int ranNum = randomGenerator.Next(1, 100);

                int guess = -1;
                int count = 0;

                while (guess != ranNum) {
                    
                    Console.Write("What is your guess? ");
                    Console.ForegroundColor = ConsoleColor.Blue;

                    guess = int.Parse(Console.ReadLine());
                    count++;

                    if (ranNum > guess) {
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine("Higher");
                    }
                    else if (ranNum < guess) {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Lower");
                    }
                    else {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("You guessed it!");
                    }
                }
                Console.WriteLine();
                Console.WriteLine($"It took you {count} guesses.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Would you like to play again (yes/no)? ");
                Console.ForegroundColor = ConsoleColor.Blue;
                string resp = Console.ReadLine();
                Console.WriteLine();

                if (resp == "no"){
                    a = false;
                }
            }
            Console.WriteLine("Thank you for playing. Goodbye.");
        }
    }
}