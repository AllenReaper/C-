using System;
using System.Transactions;


class Program
{
    static void Main(string[] args)
    {
        // these are notes 
        Console.WriteLine("Enter the radesis");
        string text = Console.ReadLine();
        double raduis = double.Parse(text);

        //compute the area
        double area = Math.PI * raduis * raduis;

        Console.WriteLine($"here: {area}");
        // "$" tells the consol to look in the line for variables.
        
          
        string s = "goodbuy";
        string x = "freak";
        float f = 3.14f;
        double d = 5.21;
        
        // <-- this is how you write notes in the code.
        /* same
        */ 
        Console.WriteLine($"Hello {x} Sandbox World! {x} you {f} freaking {d} legend!! {s}");


        Console.Write("whats your firstname?");
        string firstname = Console.ReadLine();

        Console.Write("whats your lastname?");
        string lastname = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");
    }
}