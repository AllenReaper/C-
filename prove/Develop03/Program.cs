using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "./Zcriptures.txt";
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Scripture file not found.");
            return;
        }

        ScriptureLibrary library = new ScriptureLibrary(filePath);
        Scripture scripture = library.GetRandomScripture();

        while (true)
        {
            scripture.Display();

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden. Press any key to exit.");
                Console.ReadKey();
                break;
            }

            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
                break;

            scripture.HideRandomWords(3);
        }
    }
}