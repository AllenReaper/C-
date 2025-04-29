using System;
using System.Globalization;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 20);
        
        string response = "yes";
        while (response == "yes")
        {
            Console.WriteLine(number);
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        }
        
        

    }
}