using System;
using System.Collections.Generic;

public class PromptGenerator
{
    //Creates the prompts list and populates it
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Whom did I minister today and what I did?",
        "Did someone helped me today?",
        "What did I learn from my scriptures study today?",
        "Did I learn anything new today?",
        "What news did catch my attention today?"
    };

    public string GetRandomPrompt()
    {
       //Generates a random index
       Random randomGenerator = new Random();
       int randomIndex = randomGenerator.Next(0, _prompts.Count-1);
       
       //Returns the prompt according the randomIndex
       return _prompts[randomIndex];
        
    }
}