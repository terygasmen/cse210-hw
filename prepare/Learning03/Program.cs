using System;

class Program
{
    static void Main(string[] args)
    {
        // testingfraction class

        // 1/1 
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString()); // 1/1
        Console.WriteLine(f1.GetDecimalValue()); // 1
        //5/1 (one-parameter)
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString()); //5/1
        Console.WriteLine(f2.GetDecimalValue()); // 5
        // 3/4 (twoparameter)
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString()); //3/4
        Console.WriteLine(f3.GetDecimalValue()); //0.75
        // 1/3
        Fraction f4 = new Fraction(1,3);
        Console.WriteLine(f4.GetFractionString()); //1/3
        Console.WriteLine(f4.GetDecimalValue()); //0.33

        // f4.SetNumerator(2);
        // f4.SetDenominator(5);
        // Console.WriteLine(f4.GetFractionString()); //2/5
        // Console.WriteLine(f4.GetDecimalValue()); // 0.4
    }
}