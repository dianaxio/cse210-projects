using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");
        // Fraction fraction1 = new Fraction();
        // Fraction fraction2 = new Fraction(6);
        // Fraction fraction3 = new Fraction(6, 7);

        // Fraction fraction4 = new Fraction();
        // fraction4.SetTopNumber(1);
        // fraction4.SetBottomNumber(2);
        // Console.WriteLine(fraction4.GetTopNumber());
        // Console.WriteLine(fraction4.GetBottomNumber());

        Fraction fraction5 = new Fraction();
        Console.WriteLine(fraction5.GetFractionString());
        Console.WriteLine(fraction5.GetDecimalValue());

        Fraction fraction6 = new Fraction(5);
        Console.WriteLine(fraction6.GetFractionString());
        Console.WriteLine(fraction6.GetDecimalValue());

        Fraction fraction7 = new Fraction(3, 4);
        Console.WriteLine(fraction7.GetFractionString());
        Console.WriteLine(fraction7.GetDecimalValue());

        Fraction fraction8 = new Fraction(1, 3);
        Console.WriteLine(fraction8.GetFractionString());
        Console.WriteLine(fraction8.GetDecimalValue());
    }
}