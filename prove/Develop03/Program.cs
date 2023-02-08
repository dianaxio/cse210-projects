/* 
    Author: Diana Menacho Terrel

   To show creativity and exceed the requirements: 
   I downloaded Books.csv and ESV_fixed.csv (Bible). 
   I used it to let the user search from the book, chapter, 
   start verse and end verse the user wants to choose.

    I added color so that the user can differentiate 
    the questions that the program generates, the user 
    input and the text of the bible chosen by the user.

    I used this webpage to know how to read information 
    from a csv in c#: https://stackoverflow.com/questions/5282999/reading-csv-file-and-storing-values-into-an-array
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        string book;
        int chapt;
        int startVerse;
        int endVerse;

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\n--------------------------------------");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("| Welcome to the Scripture Memorizer |");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("--------------------------------------\n");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("\nWrite the name of the book:\n>> ");
        Console.ForegroundColor = ConsoleColor.Blue;
        book = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.White;

        do
        {
            Console.Write("\nWrite the number of the chapter you want to read:\n>> ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            chapt = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            if(chapt <= 0) Console.WriteLine("\nThe chapter should be greater than 0.\n>> ");
        }while(chapt <= 0);

        do
        {
            Console.Write("\nWrite the number of the start verse:\n>> ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            startVerse = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            if(startVerse <= 0) Console.WriteLine("\nThe start verse should be greater than 0.\n>> ");
        }while(startVerse<=0);

        do
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Write the number of the end verse (write 0 if none):\n>> ");
            Console.ForegroundColor = ConsoleColor.Blue;
            endVerse = int.Parse(Console.ReadLine());
            if(endVerse <= 0) Console.WriteLine("\nThe end verse should be a positive number.");
            else if(endVerse != 0 && endVerse < startVerse)
            {
                Console.WriteLine("\nThe end verse should be greater or equal than the start verse.");
                endVerse = -1;
            }
        }while(endVerse < 0);
        
        Scripture scripture;
        if(endVerse <= 0)
        {
            scripture = new Scripture(book,chapt,startVerse);
        }
        else
        {
            scripture = new Scripture(book,chapt,startVerse,endVerse);
        }
        Console.Clear();
        scripture.DisplayScripture();
    }
}