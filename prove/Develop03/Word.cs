public class Word
{

    private string _word; // the word.
    private bool _hidden; // knows if it is hidden or not
    
    public Word(string word)
    {
        _word = word;
        int i;
        for(i = 0; i < word.Length; i++)
        {
            if(word[i] != '_') break;   
        }
        if(i ==  word.Length) _hidden = true;
        else _hidden = false;
    }
        
    public void Hide() // turns _hidden to true
    {
        _hidden = true;
        int aux = _word.Length;
        _word = string.Empty;
        for(int i = 0; i < aux; i++)
        {
            _word += '_';
        }
    } 
    public bool IsHidden() // returns if the word is hidden or not 
    {
        return _hidden;
    } 

    public string GetWord()
    {
        return _word;
    }
}