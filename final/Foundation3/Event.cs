public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _type;

    public Event(string title, string description, string date, string time, Address address, string type)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
    }
    public string StandardMessage()
    {
        return $"\nEvent Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\n{_address.ToString()}\n";
    }
    public virtual string FullDetailedMessage()
    {
        return "";
    }
    public string ShortDescription()
    {
        return $"\nEvent Type: {_type}\nEvent Title: {_title}\nEvent Date: {_date}\n";
    }
}