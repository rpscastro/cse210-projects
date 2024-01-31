using System;

class Program
{
    static void Main(string[] args)
    {
       
        Assignment test = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(test.GetSummary());

        Console.WriteLine();

        MathAssignment test2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(test2.GetSummary());
        Console.WriteLine(test2.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment test3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(test3.GetSummary());
        Console.WriteLine(test3.GetWritingInformation());


    }
}