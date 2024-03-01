using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction Fraction1 = new Fraction();
        Console.WriteLine(Fraction1.GetFractionString());
        Console.WriteLine(Fraction1.GetDecimalValue());

        Fraction1.SetTop(6);
        Console.WriteLine(Fraction1.GetFractionString());
        Console.WriteLine(Fraction1.GetDecimalValue());

        Fraction1.SetBottom(7);
        Console.WriteLine(Fraction1.GetFractionString());
        Console.WriteLine(Fraction1.GetDecimalValue());
    }
}