public class Running : Activity
{
    private double _distance;
    public Running(string date, double distance, int time) : base(date, "Running", time)
    {
        _distance = distance;
    }

    protected override double GetDistance()
    {
        return _distance;
    }
    protected override double GetSpeed()
    {
        return (_distance/GetTime())*60.0;
    }
    protected override double GetPace()
    {
        return GetTime()/GetDistance();
    }
}