using System;

class ReflectingActivity : Activity
{

    protected List<string> _prompts;
    protected List<string> _questions;

    //Stores the index of questions already used to avoid repetition
    private List<int> _usedQuestions;

    public ReflectingActivity()
    {

        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        _prompts = new List<string>();
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions = new List<string>();
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        _usedQuestions = new List<int>();

    }
    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime endActivityTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endActivityTime)
        {

            DisplayQuestions();
            ShowSpinner(10);

        }

        DisplayEndingMessage();
    }
    private string GetRandomPrompt()
    {
        //Generates a random index
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(0, _prompts.Count);
        return _prompts[randomIndex];
    }

    private string GetRandomQuestion()
    {
        //If all questions were used, clear the _usedQuestions list
        if (_usedQuestions.Count == _questions.Count)
        {

            _usedQuestions.Clear();
        }

        Random randomGenerator = new Random();
        int randomIndex;

        do
        {

            randomIndex = randomGenerator.Next(0, _questions.Count);

        } while (_usedQuestions.Contains(randomIndex));//If a question was already used, take another

        _usedQuestions.Add(randomIndex);//Updates _usedQuestions List
        return _questions[randomIndex];
    }

    private void DisplayPrompt()
    {
        Console.Write($"--- {GetRandomPrompt()} ---");
    }

    private void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion()} ");
    }

}
