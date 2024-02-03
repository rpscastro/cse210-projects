using System;
using System.ComponentModel;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of {_name} Activity.");
        ShowSpinner(5);
        Console.Clear();

    }

    protected void ShowSpinner(int seconds)
    {

        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        DateTime endSpinnerTime = DateTime.Now.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endSpinnerTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i > 7)
            {

                i = 0;
            }

        }
        Console.WriteLine();
    }
    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {

            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");


        }

    }
}