public class Activity
{
    private string _date;
    private int _time; //This is the length in minutes
    private string _activityType;

    public Activity(string date, string activityType, int time)
    {
        _date = date;
        _activityType = activityType;
        _time = time;
    }

    public string GetSummary()
    {
        return $"{_date} {_activityType} ({_time} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
    protected virtual double GetDistance()
    {
       return 0;
    }
    protected virtual double GetSpeed()
    {
        return 0;
    }
    protected virtual double GetPace()
    {
        return 0;
    }
    protected int GetTime()
    {
        return _time;
    }
}