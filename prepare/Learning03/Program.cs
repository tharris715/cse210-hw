using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction(1);
        frac1.GetFractionString();
        frac1.GetDecimalValue();

        // test SetTop
        frac1.SetTop(5);
        frac1.GetFractionString();
        frac1.GetDecimalValue();

        Fraction frac2 = new Fraction(5);
        frac2.GetFractionString();
        frac2.GetDecimalValue();

        // test SetBottom
        frac2.SetBottom(7);
        frac2.GetFractionString();
        frac2.GetDecimalValue();

        // test GetTop and GetBottom
        Console.WriteLine($"{frac2.GetTop()}");
        Console.WriteLine($"{frac2.GetBottom()}");

        Fraction frac3 = new Fraction(3, 4);
        frac3.GetFractionString();
        frac3.GetDecimalValue();

        Fraction frac4 = new Fraction(1, 3);
        frac4.GetFractionString();
        frac4.GetDecimalValue();

    }
}