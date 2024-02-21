using System;

class Program
{   
    private static List<Activity> activities = new List<Activity>();
    static void Main(string[] args)
    {
        //Testing equivalent arguments to produce the same result in the different classes
        Running running = new Running("03 Nov 2022",30,20);
        Cycling cycling = new Cycling("03 Nov 2022",30,40);
        Swimming swimming = new Swimming("03 Nov 2022",30,400);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        Console.WriteLine("***Activities Summary***");

        foreach(Activity activity in activities){

            Console.WriteLine(activity.GetSummary());
        }
      
    }
}