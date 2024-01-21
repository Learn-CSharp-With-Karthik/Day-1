// This is a library that contains all the builtin functions
using System;

// Namespace is like a folder that contains classes and functions
namespace Day1
{
    // class - container that contains set of methods
    class Program
    {
        // Your Main function is always like an entry to C# Program
        static void Main()
        {
            // WriteLine is used to write things to the terminal
            Console.WriteLine("Hello Arshad!");
            // ReadKey is used to hold on the screen until you press a key
            Console.ReadKey();
            // Read Input from the User
            Console.WriteLine("Enter your Name : ");
            string name = Console.ReadLine();
            //Concatenation Method
            Console.WriteLine("Your Name is " + name);
            // Arguments
            string name2 = "John";
            string name3 = "Karl";
            Console.WriteLine("Your Name is {0}, {1}, {2}", name, name2, name3);

            // Read and Write for Integers
            Console.WriteLine("Enter 1st Number - ");
            // Console.ReadLine - Takes all input by default in the form of string
            // In order to convert to an integer use int.Parse()
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number - ");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("The Sum is {0}", sum);
            Console.ReadKey();
        }
    }
}
