using System;
using System.IO;



class Program
{
    static void Main(string[] args)
    {
        int option;
        
        // Creates the objects for prompts and journal
        PromptGenerator prompt = new PromptGenerator();
        Journal journal = new Journal();
        
        do
        {
            //Displays the menu
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

       
           
            //Stores the option in a variable
            option = int.Parse(Console.ReadLine());

            if (option == 1) // Write
            {
               //Gets a ramdom prompt and stores in a variable
               string promptEntry = prompt.GetRandomPrompt();

               //Displays the prompt for the user
               Console.WriteLine(promptEntry);

               //Gets the entry from the user input
               string textEntry = Console.ReadLine();

               //Gets the date and time from the system
               DateTime theCurrentTime = DateTime.Now;

               //Stores the date and time in variables
               string dateText = theCurrentTime.ToShortDateString();
               string timeText = theCurrentTime.ToShortTimeString();

              
               //Creates a new Entry
               Entry entry = new Entry(dateText, timeText, promptEntry, textEntry);
               
               //Adds the entry to the journal
               journal.AddEntry(entry);
               

            }
            else if (option == 2) // Display
            {
                //Calls the method of Journal class
                journal.DisplayAll();

            }
            else if (option == 3) // Load
            {
                //Gets the filename from the user
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();

                //Calls the method of Journal class
                journal.LoadFromFile(filename);    

            }
            else if (option == 4)
            {   
                ///Gets the filename from the user
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();

               //Calls the method of Journal class
               journal.SaveToFile(filename);
            }


        } while (option != 5); //It will stop the loop when option = 5


    }
 
}