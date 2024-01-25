using System;

class Program
{
    static void Main(string[] args)
    {
        
        //Inserting a scripture
        Reference reference = new Reference("Proverbs",3,5,6);
        string scripture_text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
      
        Scripture scripture = new Scripture(reference, scripture_text);

        //Stores de option typed by the user
        string option;
        
        //Words to hide in each iteration
        int numberToHide = 3;

        do
        {

            // Display the scripture text
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            
            
            option = Console.ReadLine();
            

            //If the the scripture is completely hidden the option is changed to quit to stop the program
            if(scripture.IsCompletelyHidden()){

                option = "quit";
            }

            if(option != "quit"){
                // This will clear the console
                Console.Clear();

                // Calls the hide words method
                scripture.HideRandomWords(numberToHide);

                           
            }



        }while (option != "quit");




    }
}