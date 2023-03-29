public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(string date, int numberOfLaps, int time) : base(date, "Swimming", time)
    {
        _numberOfLaps = numberOfLaps;
    }

    protected override double GetDistance()
    {
        return (_numberOfLaps*50.0)/1000;
    }
    protected override double GetSpeed()
    {
        return (GetDistance()/GetTime())*60.0;
    }
    protected override double GetPace()
    {
        return GetTime()/GetDistance();
    }
}