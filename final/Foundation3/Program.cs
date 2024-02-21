using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("101 E Viking St", "Rexburg", "ID", "USA");
        Address address2 = new Address("Rua Arlindo Béttio, 1000", "São Paulo", "SP", "BRAZIL");
        Address address3 = new Address("55-220 Kulanui St", "Laie", "HI", "USA");

        Lecture lecture = new Lecture("Programming with Classes",
                                      "CSE 210 Presentation - Programming with Classes Using C#",
                                       address1,
                                       "March 1st, 2024",
                                       "7 PM",
                                       "Carter, Eric",
                                       100);


        Reception reception = new Reception("Sistemas de Informação",
                                            "Uma recepção para formandos do curso de Sistemas de Informação",
                                            address2,
                                            "March 1st, 2024",
                                            "7 PM",
                                            "rsvp@each.edu.br");

        Outdoor outdoor = new Outdoor("BYU - Hawaii",
                                    "Presenting BYU - Hawaii",
                                    address3,
                                    "March 1st, 2024",
                                    "3 PM",
                                    "Sunny");

        
        //Printing info
        //Short Descriptions
        Console.WriteLine("Printing Marketing Info");
        Console.WriteLine("***Short Descriptions***");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(outdoor.GetShortDescription());
        Console.WriteLine();

        //Standard Details
        Console.WriteLine("***Standard Details***");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine();
        
        //Full Details
        Console.WriteLine("***Full Details***");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine();

       
    }

  
}