using System;

namespace Prep2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your grade percent? ");
            string answer = Console.ReadLine();
            int percent = int.Parse(answer);
            
            // ""= null
            string letter = null;


            if (percent >= 90) {
                letter = "A";
            }
            else if (percent >= 80) {
                letter = "B";
            }
            else if (percent>= 70) {
                letter = "C";
            }
            else if (percent >= 60) {
                letter = "D";
            }
            else {
                letter = "F";
            }

            // Stretch Challenge 1
            
            int last_digit = percent % (10);
            // "" = null
            string sign = null;  

            if (last_digit >= 7) {
                sign = "+";
            }
            else if (last_digit < 3) {
                sign = "-";
            }
            else {
                sign = "";
            }
            // Stretch Challenge 2

            if (percent >= 93) {
                sign = "";
            }

            //Stretch Challenge 3
            if (answer == "F") {
                sign = "";
            }

            Console.WriteLine($"Your letter grade is: {letter}{sign}");

            if (percent >= 70) {
                Console.WriteLine("Congratulations! You passed the class!");
            }
            else {
                Console.WriteLine("Stay focused and you'll get it next time!");
            }
        }
    }
}