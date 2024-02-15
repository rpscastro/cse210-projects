using System;

class Program
{
    static void Main(string[] args)
    {

        Address address1 = new Address("101 E Viking St","Rexburg", "ID","USA");
        Address address2 = new Address("Rua Arlindo Béttio, 1000","São Paulo", "SP","BRAZIL");

        Customer customer1 = new Customer("BYU Idaho", address1);
        Customer customer2 = new Customer("USP Each", address2);

        
        Order order1 = new Order(customer1);
        
        Product product1O1 = new Product("Notebook","1A",5.50,1);
        Product product2O1 = new Product("Pen","2A",1.50,2);
        Product product3O1 = new Product("Pencil","3A",0.50,1);

        order1.AddProduct(product1O1);
        order1.AddProduct(product2O1);
        order1.AddProduct(product3O1);

        Order order2 = new Order(customer2);

        Product product1O2 = new Product("Eraser","1B",1.00,2);
        Product product2O2 = new Product("Ruler","2B",2.50,2);
        Product product3O2 = new Product("Backpack","3B",40.5,1);

        order2.AddProduct(product1O2);
        order2.AddProduct(product2O2);
        order2.AddProduct(product3O2);        

        DisplayInfo(order1);
        DisplayInfo(order2);

    }

    static void DisplayInfo(Order order){

        
        Console.WriteLine($"Order for customer: {order.GetCustomer().GetName()}");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.CreatePackingLabel());
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.CreateShippingLabel());
        Console.WriteLine();
        Console.WriteLine("Total Price of the Order:");
        Console.WriteLine($"US$ {String.Format("{0:0.00}",order.CalculateTotalCost())}");
        Console.WriteLine();
    }
}