using System;

public class Fraction 
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;   
        // Console.WriteLine($"{_top}/{_bottom}");
    }
    public Fraction(int top)
    {   
        _top = top;
        _bottom = 1;
        // Console.WriteLine($"{_top}/{_bottom}");
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;   
        // Console.WriteLine($"{_top}/{_bottom}");
    }

    public int GetTopNumber()
    {
        return _top;
    }
    public int GetBottomNumber()
    {
        return _bottom;
    }

    public void SetTopNumber(int topNumber)
    {
        _top = topNumber;
    }
    public void SetBottomNumber(int bottomNumber)
    {
        _bottom = bottomNumber;
    }

    public string GetFractionString()
    {
        string fraction = $"{_top}/{_bottom}";
        return fraction;        
    }

    public double GetDecimalValue() 
    {   
        double fraction = Convert.ToDouble(_top) / Convert.ToDouble(_bottom);
        return fraction;
        // sample solution --> return (double)_top / (double)_bottom;
    }

}