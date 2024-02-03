using System;

class BreathingActivity : Activity
{

    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void Run()
    {
        DisplayStartingMessage();

        DateTime endActivityTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endActivityTime)
        {

            Console.WriteLine();


            Console.Write($"Breathe in...");
            ShowCountDown(4);

            Console.WriteLine();

            Console.Write($"Now breathe out...");
            ShowCountDown(6);

            Console.WriteLine();

        }

        DisplayEndingMessage();

    }


}