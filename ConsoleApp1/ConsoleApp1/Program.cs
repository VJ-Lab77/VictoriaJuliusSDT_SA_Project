using System;

namespace ConsoleApp1 {     
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welocome to the Structure of a C# Program Demo!");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}");

            Console.WriteLine("Program Structure Demostrated: ");
            Console.WriteLine("1. using System: importes functionality");
            Console.WriteLine("2. Namespace: origanize code");
            Console.WriteLine("3. Class: container for code");
            Console.WriteLine("4. Main Method: Entry point of the program");
            Console.WriteLine("5. Comments : explain logic and documentation");


            Console.WriteLine("Program executed successfully!");

        }
    }
}
