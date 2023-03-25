public class Video
{
    private string _title;
    private string _author;
    private int _time;
    private List<Comment> _comments;

    public Video(string title, string author, int time)
    {
        _title = title;
        _author = author;
        _time = time;
        _comments = new List<Comment>();
    }
    public void AddComment(string author, string comment)
    {
        Comment newComment = new Comment(author,comment);
        _comments.Add(newComment);
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public int GetTime()
    {
        return _time;
    }
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
    public void DisplayVideoData()
    {
        DisplaySeparator();
        Console.WriteLine("\nVideo Title: {0}",_title);
        Console.WriteLine("\nVideo Author: {0}",_author);
        Console.WriteLine("\nVideo Length in Seconds: {0}",_time);
        Console.WriteLine("\nVideo Length in HH:MM:SS: {0}",GetTimeInHHMMSS());
        Console.WriteLine("\nVideo Number of Comments: {0}",GetNumberOfComments());
        Console.WriteLine("\nVideo Comments:\n");
        DisplayVideoComments();
        DisplaySeparator();
    }

    private void DisplayVideoComments()
    {
        foreach(Comment comment in _comments)
        {
            Console.WriteLine($"{comment.GetName()}:\n    {comment.GetComment()}");
        }
    }
    private void DisplaySeparator()
    {
        for(int i = 0; i < 50; i++)
        {
            Console.Write("- ");
        }
    }
    private string GetTimeInHHMMSS()
    {
        int time = _time;
        int HH = time/3600;
        time = time-HH*3600;
        int MM = time/60;
        time = time-MM*60;
        int SS = time;
        string[] zero = new string[3];
        if(HH < 10)
        {
            zero[0] = "0";
        }
        else
        {
            zero[0] = "";
        }
        if(MM < 10)
        {
            zero[1] = "0";
        }
        else
        {
            zero[1] = "";
        }
        if(SS < 10)
        {
            zero[2] = "0";
        }
        else
        {
            zero[2] = "";
        }
        return $"{zero[0]}{HH}:{zero[1]}{MM}:{zero[2]}{SS}";
    }
}