/*
 Author: Brett Hartman
 Date: 9/19/20
 Comments: This C# application is for Tech Project 3A
           It demonstrates the use of Methods to take the user's name
           and print it to Console.
*/
using System;

namespace TechProject3A
{
    class Program
    {
        static void Main(string[] args)
        {
            // Provide User with instructions to take input
            Console.WriteLine("Please enter your name:");

            // Use try catch block to validate input
            try
            {
                // Define variable to take input from user
                string user_name = Console.ReadLine();

                // Say hello to the user!
                Console.WriteLine("Hello " + user_name + "!");

                // Tell user how to exit program
                Console.WriteLine("Press any key to exit the program and try again");

                // Take input and close program
                Console.ReadKey(true);
            } // End Try

            catch
            {
                // Provide error message and further instructions
                Console.WriteLine("You must enter a string value for your name.");
                Console.WriteLine("Press any key to exit the prgram and try again");
                Console.ReadKey(true);
            } // End Catch
        } // End Main
    } // End Class
} // End Namespace
