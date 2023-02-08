public class Verse
{
    private string _verse; // The verse

    public Verse(string verse)
    {
        _verse = verse;
    }

    public void Hide3Words() // hide 3 random words in the verse
    {

        string[] words = SplitInWords();
        Word[] verseWords = new Word[words.Length];
        int help = 0;
        foreach(string w in words)
        {
            verseWords[help] = new Word(w);
            help++;
        }
        Random randomNumber = new Random();
        int[] num = new int[3];
        for(int i = 0; i < 3; i++)
        {
            do{
                num[i] = randomNumber.Next(0,verseWords.Length); 
            }while(verseWords[num[i]].IsHidden());
        }
        Array.Sort(num);
        for(int i = 0, j = 0; i < verseWords.Length && j < 3; i++)
        {
            if(i == num[j])
            {
                verseWords[num[j]].Hide();
                j++;
            }
        }
        for(int i = 0; i < words.Length; i++)
        {
            words[i] = verseWords[i].GetWord();
        }
        RebuildVerse(words);

    } 
    private string[] SplitInWords() // split the verse in words and return the array with the words
    {
        return _verse.Split(" ");
    }
    private void RebuildVerse(string[] verseWords) // Modifies the verse with the new hidden words
    {
        _verse = "";
        foreach(string word in verseWords){
            _verse += word + " ";
        }
        _verse = _verse.TrimEnd(' ');
    }
    public string GetVerse(){
        return _verse;
    }
    public void Display(){
        Console.Write(GetVerse());
    }
    public bool TotallyHidden() // tells if the verse is totally hidden
    {
        int i;
        for(i = 0; i < _verse.Length; i++)
        {
            if(_verse[i].Equals(' ')) continue;
            if(_verse[i] != '_') break;
            
        }
        if(i ==  _verse.Length) return true;
        else return false;
    }
}