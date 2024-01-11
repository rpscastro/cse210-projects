using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input your grade pecentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());
        
        string gradeLetter = "";
        string sign = "";
        int lastDigit = gradePercentage % 10;
        string message = "";

        
        // Define grade letter

        if (gradePercentage >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradePercentage >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradePercentage >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradePercentage >= 60)
        {
            gradeLetter = "D";
        }
        else if (gradePercentage < 60)
        {
            gradeLetter = "F";
        }

        //Define grade sign
        if (lastDigit >= 7 && (gradeLetter != "A" && gradeLetter != "F" ))
        {
            sign = "+";
        }
        else if (lastDigit < 3 && (gradeLetter != "F" ))
        {
            sign = "-";
        }

        // Define message
        if (gradePercentage >= 70)
        {
           message = "Congratulations! You have passed!"; 
        }
        else
        {
           message = "Sorry, you have not passed. Keep trying!"; 
        }


        // Print results
        Console.WriteLine();
        Console.WriteLine($"Your letter grade is: {gradeLetter}{sign}");
        Console.WriteLine();
        Console.WriteLine(message);
        
        

    }
}