using System;

class ListingActivity : Activity
{
    private int _count ;
    private List<string> _prompts;

    public ListingActivity(){
        
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _prompts = new List<string>();
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }
    

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        DateTime endActivityTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endActivityTime)
        {
           
           Console.Write("> ");
           Console.ReadLine();
           _count++;
           
        }
       
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }

    private void GetRandomPrompt()
    {
        //Generates a random index
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(0, _prompts.Count);
        Console.WriteLine($"--- {_prompts[randomIndex]} ---");
    }

}