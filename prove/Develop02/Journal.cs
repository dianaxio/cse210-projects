public class Journal{
    private static List<Entry> _entries = new List<Entry>(); // List of the entries we have.
    private string _file; // File where we are going to be saving the Journal/entries.

    public void Write(){ // Write a new entry in the journal.
        Entry entry = new Entry();
        Console.ForegroundColor = ConsoleColor.White;

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        entry._date = dateText;
        Prompt prompt = new Prompt();
        entry._prompt = prompt.Random();
        Console.Write($"\n\n{entry._prompt}");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("\n\n→ ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Blue;
        entry._answer = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.White;
        _entries.Add(entry);
    } 
    public void Display(){ // Show the Journal / the list of entries.
        foreach(Entry entry in _entries){
            entry.Display();
        }
    } 
    public void SaveToFile(){ // save the journal into the file.
        Console.WriteLine("\n What is the filename?: ");
        Console.ForegroundColor = ConsoleColor.Blue;
        _file = Console.ReadLine();    
        Console.ForegroundColor = ConsoleColor.White;

        using (StreamWriter outputFile = new StreamWriter(_file)){
            foreach(Entry entry in _entries)
                outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._answer}");
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nJournal saved successfully");
        Console.ForegroundColor = ConsoleColor.White;
    } 
    public void LoadFromFile(){ // load the journal from the file.
        Console.WriteLine("\nWhat is the filename?: ");   
        _file = Console.ReadLine();
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(_file);
        foreach (string line in lines){
            Entry aux = new Entry();
            string[] parts = line.Split(",");
            aux._date = parts[0];
            aux._prompt = parts[1];
            aux._answer = parts[2];
            _entries.Add(aux);
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nJournal loaded successfully");
        Console.ForegroundColor = ConsoleColor.White;    
    } 
}