using System;
using System.Collections.Generic;

namespace Prep5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Prep 5");

            DisplayWelcome();

            string inputName = PromptUserName();

            int inputNumber = PromptUserNumber();

            int squaredNumber = SquareNumber(inputNumber);

            DisplayResult (inputName, squaredNumber);


            static void DisplayWelcome()
            {
                Console.WriteLine("Welcome to the program!");
            }

            static string PromptUserName()
            {
                Console.WriteLine("What is your name? ");
                string name = Console.ReadLine();
                return name;
            }
            
            static int PromptUserNumber()
            {
                Console.WriteLine("Please enter your favorite number: ");
                int number = int.Parse(Console.ReadLine());
                return number;
            }
            
            static int SquareNumber(int number)
            {
                int square = number * number;
                return square;
            }

            static void DisplayResult(string name, int square)
            {
                Console.WriteLine($"{name}, the square of your number is {square}.");
            }
        }
    }
}