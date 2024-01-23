using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Console.WriteLine("Checking constructor 1:");

        Fraction frac1 = new Fraction();

        Console.WriteLine(frac1.GetFractionString());

        Console.WriteLine("Checking constructor 2:");

        Fraction frac2 = new Fraction(6);

        Console.WriteLine(frac2.GetFractionString());

        Console.WriteLine("Checking constructor 3:");

        Fraction frac3 = new Fraction(6,7);

        Console.WriteLine(frac3.GetFractionString());

        Console.WriteLine("Checking Getters Numerators:");

        Console.WriteLine(frac1.GetTop());
        Console.WriteLine(frac2.GetTop());
        Console.WriteLine(frac3.GetTop());

        
        Console.WriteLine("Checking Getters Denominators:");

        Console.WriteLine(frac1.GetBottom());
        Console.WriteLine(frac2.GetBottom());
        Console.WriteLine(frac3.GetBottom());

        Console.WriteLine("Checking Setters Numerators (Setting All To 5):");

        frac1.SetTop(5);
        frac2.SetTop(5);
        frac3.SetTop(5);

        Console.WriteLine(frac1.GetTop());
        Console.WriteLine(frac2.GetTop());
        Console.WriteLine(frac3.GetTop());
        
        Console.WriteLine("Checking Setters Denominators (Setting All To 10):");
        
        frac1.SetBottom(10);
        frac2.SetBottom(10);
        frac3.SetBottom(10);

        Console.WriteLine(frac1.GetBottom());
        Console.WriteLine(frac2.GetBottom());
        Console.WriteLine(frac3.GetBottom());
        
        Console.WriteLine("Checking Constructors and Methods:");
        
        Fraction frac4 = new Fraction();
        Console.WriteLine(frac4.GetFractionString());
        Console.WriteLine(frac4.GetDecimalValue());
        
        Fraction frac5 = new Fraction(5);
        Console.WriteLine(frac5.GetFractionString());
        Console.WriteLine(frac5.GetDecimalValue());
       
        Fraction frac6 = new Fraction(3,4);
        Console.WriteLine(frac6.GetFractionString());
        Console.WriteLine(frac6.GetDecimalValue());       
        
        Fraction frac7 = new Fraction(1,3);
        Console.WriteLine(frac7.GetFractionString());
        Console.WriteLine(frac7.GetDecimalValue());  





    }
}