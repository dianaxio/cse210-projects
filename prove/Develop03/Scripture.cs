//I used this webpage to know how to read information from a csv in c#: https://stackoverflow.com/questions/5282999/reading-csv-file-and-storing-values-into-an-array
public class Scripture
{
    private string _book; 
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    private List<Verse> _verses = new List<Verse>();

    public Scripture(string book, int chapt, int verse)
    {
        _book = book;
        _chapter = chapt;
        _startVerse = verse;
        _endVerse = verse;
        ReadFromFile();
    }
    public Scripture(string book, int chapt, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapt;
        _startVerse = startVerse;
        _endVerse = endVerse; 
        ReadFromFile(); 
    } 

    private void ReadFromFile()  //exceeding requirements
    {
        List<string> booksNumbers1 = new List<string>();
        List<string> booksName = new List<string>();
        List<string> chaptersMax = new List<string>();
        using(var reader = new StreamReader("Books.csv"))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                booksNumbers1.Add(values[0]);
                booksName.Add(values[2]);
                chaptersMax.Add(values[3]);
            }
        }
        List<string> booksNumbers2 = new List<string>();
        List<string> chaptNumbers = new List<string>();
        List<string> verseNumbers = new List<string>();
        List<string> verses = new List<string>();
        using(var reader = new StreamReader("ESV_fixed.csv"))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                booksNumbers2.Add(values[0]);
                chaptNumbers.Add(values[1]);
                verseNumbers.Add(values[2]);
                if(values.Length > 4)
                {
                    for(int g = 4; g < values.Length; g++)
                    {
                        values[3]+=","+values[g];
                    }
                }
                verses.Add(values[3]);
            }
        }
        int bookNumber = 0;
        do{
            bool found = false;
            foreach(string bookName in booksName)
            {
                if(_book.ToLower().Equals(bookName.ToLower()))
                {
                    bookNumber = int.Parse(booksNumbers1[bookNumber]); 
                    found = true;
                    int chapMax = int.Parse(chaptersMax[bookNumber]);
                    if(chapMax < _chapter)
                    {   
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nThe last chapter of this book is chapter {0} and you are searching chapter {1}. Please try again.\n",chapMax,_chapter);
                        do
                        {
                            Console.Write("Write the number of the chapter you want to read: ");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            _chapter = int.Parse(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.White;
                            if(_chapter <= 0 || _chapter>chapMax) Console.WriteLine($"\nThe chapter should be greater than 0 and lower or equal than {chapMax}.\n");
                        }while(_chapter <= 0 || _chapter>chapMax);
                    }
                    break;
                }
                bookNumber++;
            }
            if(!found)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("The book was not found, please write the book's name again:\n>> ");
                Console.ForegroundColor = ConsoleColor.Blue;
                _book = Console.ReadLine();
                bookNumber = 0;
            }
            else break;
        }while(true);
        for(int i = 0; i < booksNumbers2.Count; i++)
        {
            if(bookNumber == int.Parse(booksNumbers2[i]))
            {
                for(int j = i; j < chaptNumbers.Count; j++)
                {
                    if(_chapter == int.Parse(chaptNumbers[j]))
                    {
                        for(int h = j, verseCounter = 0, versesMax = 0; h < verseNumbers.Count; h++, verseCounter++)
                        {
                            if(!chaptNumbers[h].Equals(chaptNumbers[j]))
                            {
                                versesMax = verseCounter;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\nThe last verse of this chapter is verse {0} and you are searching verse {1}. Please try again.\n",versesMax,_startVerse);
                                do
                                {
                                    Console.Write("Write the number of the start verse:\n>> ");
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    _startVerse = int.Parse(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.White;
                                    _endVerse = _startVerse;
                                    if(_startVerse <= 0 || _startVerse > versesMax) Console.WriteLine($"\nThe start verse should be greater than 0 and lower or equal than {versesMax}.\n");
                                }while(_startVerse<=0 || _startVerse > versesMax);

                                do
                                {
                                    Console.Write("Write the number of the end verse (write 0 if none):\n>> ");
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    _endVerse = int.Parse(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.White;
                                    if(_endVerse <= 0) Console.WriteLine("\nThe end verse should be a positive number.\n");
                                    else if(_endVerse != 0 && _endVerse < _startVerse)
                                    {
                                        Console.WriteLine("\nThe end verse should greater or equal than the start verse.\n");
                                        _endVerse = -1;
                                    }
                                    else if(_endVerse > versesMax)
                                    {
                                        Console.WriteLine($"\nThe end verse should be lower or equal than {versesMax}.\n");
                                        _endVerse = -1;    
                                    }
                                }while(_endVerse < 0);
                                if(_endVerse == 0) _endVerse = _startVerse;
                                h = h - verseCounter-1;
                                verseCounter = -1;
                                continue;
                            }
                            if(_startVerse == int.Parse(verseNumbers[h]))
                            {
                                for(int k = h; k < verses.Count; k++ , verseCounter++)
                                {
                                    if(!chaptNumbers[k].Equals(chaptNumbers[h]))
                                    {
                                        versesMax = verseCounter;
                                        Console.WriteLine("\nThe last verse of this chapter is verse {0} and you are searching verse {1}. Please try again.\n",versesMax,_endVerse);
                                        do
                                        {
                                            Console.Write("Write the number of the end verse (write 0 if none):\n>> ");
                                            _endVerse = int.Parse(Console.ReadLine());
                                            if(_endVerse <= 0) Console.WriteLine("\nThe end verse should be a positive number.\n");
                                            else if(_endVerse != 0 && _endVerse < _startVerse)
                                            {
                                                Console.WriteLine("\nThe end verse should greater or equal than the start verse.\n");
                                                _endVerse = -1;
                                            }
                                            else if(_endVerse > versesMax)
                                            {
                                                Console.WriteLine($"\nThe end verse should be lower or equal than {versesMax}.\n");
                                                _endVerse = -1;    
                                            }
                                        }while(_endVerse < 0);
                                        if(_endVerse == 0) _endVerse = _startVerse;
                                        k = h-1;
                                        _verses.Clear();
                                        continue;
                                    }
                                    verses[k] = verses[k].Replace('"'.ToString(),"");
                                    Verse aux = new Verse(verses[k]);
                                    _verses.Add(aux);
                                    if(_endVerse == int.Parse(verseNumbers[k])) break;
                                }
                                break;
                            }
                        }
                        break;
                    }
                }
                break;
            }
        }
    }
    public void DisplayScripture() 
    {
        bool flag = true;
        int turn = 0;
        do{
            _book = char.ToUpper(_book[0]) + _book.Substring(1);
            Console.ForegroundColor = ConsoleColor.Blue;
            if(_endVerse == _startVerse) Console.Write($"{_book} {_chapter}:{_startVerse} ");
            else Console.Write($"{_book} {_chapter}:{_startVerse}-{_endVerse} ");
            foreach(Verse verse in _verses){
                verse.Display();
                Console.Write(' ');
            }
            int cont = 0;
            foreach(Verse verse in _verses){
                if(verse.TotallyHidden()) cont++;
            }
            if(cont == _verses.Count) break;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\nPress enter to continue or type 'quit' to finish: ");
            string aux = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n----------------------------------");
            Console.Write(" Thank you for using this program!");
            Console.WriteLine("\n----------------------------------\n");

            if(aux.ToLower().Equals("quit"))
            {
                break;
            }
            while(_verses[turn].TotallyHidden()){
                turn++;
                if(turn >= _verses.Count-1) turn = 0;
            }
            _verses[turn].Hide3Words();
            if(turn == _verses.Count-1) turn = 0;
            else turn++;
            Console.Clear();
        }while(flag);

    }
}