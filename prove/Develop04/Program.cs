using System;

class Program
{
    static void Main(string[] args)
    {
             

        //Stores de option typed by the user
        string option;
        
        

        do
        {

            // Display the menu
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
                
            
            option = Console.ReadLine();
            
            if(option == "1"){
                Console.Clear();
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }

            if(option == "2"){
                Console.Clear();
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
            }

            if(option == "3"){
                Console.Clear();
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
           


        }while (option != "4");
    }
}