using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionValue());
        Console.WriteLine(f1.GetFractionString());
        f1.SetTop(5);
        f1.SetBottom(7);
        Console.WriteLine(f1.GetFractionValue());
        Console.WriteLine(f1.GetFractionString());

        Fraction f2 = new Fraction(6);
        Console.WriteLine(f1.GetFractionValue());
        Console.WriteLine(f1.GetFractionString());
        f2.SetTop(10);
        f2.SetBottom(3);
        Console.WriteLine(f1.GetFractionValue());
        Console.WriteLine(f2.GetFractionString());

        Fraction f3 = new Fraction(6, 7);
        Console.WriteLine(f1.GetFractionValue());
        Console.WriteLine(f1.GetFractionString());
        f3.SetTop(5);
        f3.SetBottom(9);
        Console.WriteLine(f1.GetFractionValue());
        Console.WriteLine(f3.GetFractionString());

    }
}