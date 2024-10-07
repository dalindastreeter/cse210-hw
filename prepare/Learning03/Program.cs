using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction nopara = new Fraction();
        Console.WriteLine(nopara.GetFractionString());
        Console.WriteLine(nopara.GetDecimalValue());

        Fraction whole = new Fraction(5);
        Console.WriteLine(whole.GetFractionString());
        Console.WriteLine(whole.GetDecimalValue());

        Fraction ambos= new Fraction(3,4);
        Console.WriteLine(ambos.GetFractionString());
        Console.WriteLine(ambos.GetDecimalValue());

        Fraction ambosb= new Fraction(1,3);
        Console.WriteLine(ambosb.GetFractionString());
        Console.WriteLine(ambosb.GetDecimalValue());



    }
}