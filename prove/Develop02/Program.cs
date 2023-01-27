using System;

/*  For Exceeding Requirements: I added the option in the 
    main menu to add and delete new prompts to the journal, 
    this changes are saved in a file called prompts.txt */

/*  I added color to the journal program to distinguish 
    between the questions and the answers
    
    I used this webpage to know about how to handle the FileNotFoundException: 
    https://rollbar.com/blog/csharp-filenotfoundexception/#:~:text=One%20of%20the%20most%20commonly,mismatch%20in%20the%20file%20name.
    
    I used this webpage to know how to clear a list in c#: 
    https://www.techiedelight.com/es/delete-all-items-from-a-list-in-csharp/#:~:text=Una%20soluci%C3%B3n%20simple%20y%20directa,Clear()%20m%C3%A9todo. 
*/

class Program
{
    static void Main(string[] args)
    {
        // Clean the screen
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;

        string titleArt = @"
           __________  
          ()_________)
           \ ~Journal~\
            \  ~~~~~~  \
             \ ~~~~~~~~ \
              \__________\
               ()__________)";

        Console.WriteLine(titleArt);
        Console.WriteLine("\n\t-----------------------------------");
        Console.WriteLine("\t| Welcome to the Journal Program! |");
        Console.WriteLine("\t-----------------------------------");
        Console.ForegroundColor = ConsoleColor.White;
        
        bool flag = true;
        do{
             // Displays the menu
             /* A switch statement that is checking the value of the variable
            choise and then executing the code in the case that matches
            the value of choise. */

            Console.WriteLine("\n Please select one of the following choices:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\n1. Write\n2. Display\n3. Load\n4. Save\n5. Write new Prompt\n6. Delete a Prompt\n7. Quit");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\n What would you like to do?: ");

            Console.ForegroundColor = ConsoleColor.Blue;
            int choise = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Journal myJournal = new Journal();
            Prompt myPrompts = new Prompt();
            
            switch(choise){
                case 1:
                    myJournal.Write();
                    
                    break;
                case 2:
                    myJournal.Display();
                    break;
                case 3:
                    myJournal.LoadFromFile();
                    break;
                case 4:
                    myJournal.SaveToFile();
                    break;
                case 5:
                    myPrompts.Write();
                    break;
                case 6:
                    myPrompts.Delete();
                    break;
                case 7:
                    flag = false;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\nThank you for using our program. We hope to see you soon!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                
                // Print message for invalid option
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInvalid entry: please enter the correct menu option");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }while(flag);
    }
}