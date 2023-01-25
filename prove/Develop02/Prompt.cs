public class Prompt{

    private static List<string> _prompts = new List<string>(); // for Exceeding Requirements, I added the option to add and delete new prompts to the journal and this is the list of prompts.
    private string _file = "prompts.txt"; // the file where we are going to find the prompts.
    public string Random(){ // get a random prompt.
        if(_prompts.Count == 0) LoadFromFile();
        Random randomGenerator = new Random();
        return _prompts[randomGenerator.Next(0,_prompts.Count)];
    }
    public void Delete(){ // delete a prompt.
        if(_prompts.Count == 0) LoadFromFile();
        if(_prompts.Count == 1){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nWARNING: You must have at least 1 prompt. You can not delete the last prompt.");
            Console.ForegroundColor = ConsoleColor.White;
            return;
        }
        Console.WriteLine("\nWhich prompt do you want to delete?:\n");

        int i = 0;
        foreach(string prompt in _prompts){
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{i+1}: {prompt}");
            Console.ForegroundColor = ConsoleColor.White;
            i++;
        }
        bool flag = false;
        do{
            Console.Write("\nWrite the number: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            int index = int.Parse(Console.ReadLine())-1;
            Console.ForegroundColor = ConsoleColor.White;

            if(index < 0 || index > _prompts.Count-1){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNo valid number (Number Out of Range). Please try again:");
                Console.ForegroundColor = ConsoleColor.White;

                flag = true;
            }else{
                _prompts.RemoveAt(index);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nPrompt removed successfully");
                Console.ForegroundColor = ConsoleColor.White;

                flag = false;
            }
        }while(flag);
        SaveToFile();
    }
    public void Write(){ // write a new prompt.
        if(_prompts.Count == 0) LoadFromFile();
        
        Console.Write("\nWrite the prompt that you want to add: ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("\nPrompt: ");
        Console.ForegroundColor = ConsoleColor.Blue;
        _prompts.Add(Console.ReadLine());
        
        SaveToFile();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nPrompt added successfully");
        Console.ForegroundColor = ConsoleColor.White;
    }
    private void SaveToFile(){ // save the prompt into the file.
        using (StreamWriter outputFile = new StreamWriter(_file)){
            foreach(string prompt in _prompts)
            outputFile.WriteLine(prompt);
        }
    }
    private void LoadFromFile(){ // load the prompts from the file.
        try {
            string[] lines = System.IO.File.ReadAllLines(_file);
        // Looping through the lines
            foreach (string line in lines){
                _prompts.Add(line);
            }
        }catch (FileNotFoundException) {
            using (StreamWriter outputFile = new StreamWriter(_file)){
                outputFile.WriteLine("If I had one thing I could do over today what would it be?");
                outputFile.WriteLine("What was the best part of my day?");
                outputFile.WriteLine("Who was the most interesting person I interacted with today?");
                outputFile.WriteLine("What was the strongest emotion I felt today?");
                outputFile.WriteLine("How did I see the hand of the Lord in my life today?");
            } 
            LoadFromFile();
        }
    }
}