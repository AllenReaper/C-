using System;
using System.Transactions;


class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 20);


        string response = "yes";

        while (response == "yes")
        {
            Console.WriteLine(number);
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        }
        for (int i = 2; i <= 20; i = i + 2)
{
    Console.WriteLine(i);
}
    }
}
