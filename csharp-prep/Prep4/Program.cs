using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers;
        numbers = new List<int>();

        int number = 99;
        int suma = 0;
        int largestNumber = 0;
        float average;
       

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }

        }
        for (int i = 0; i < numbers.Count; i++)
        { 
            suma += numbers[i];
            if (i == 0)
            {
                largestNumber = numbers[i];
            }
            else if (largestNumber < numbers[i])
            {
                largestNumber = numbers[i];
            }
            
        }        

        average = ((float)suma) /numbers.Count;

        Console.WriteLine($"The sum is: {suma}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}