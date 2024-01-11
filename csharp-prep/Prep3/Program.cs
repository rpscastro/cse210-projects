using System;

class Program
{
    static void Main(string[] args)
    {
       
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int guessNumber;
        do
        {
           Console.Write("What is your guess? ");
           guessNumber = int.Parse(Console.ReadLine());
           
           if (magicNumber < guessNumber)
           {
            Console.WriteLine("Lower");
           }
           else if (magicNumber > guessNumber)
           {
            Console.WriteLine("Higher");
           }


        } while (magicNumber != guessNumber);

        Console.WriteLine($"You guessed it! The Magic Number was {magicNumber}.");

    }
}