using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an Animal object
            Animal lion = new Animal();

            // Set the properties
            lion.Name = "Leo";
            lion.Age = 5;
            lion.Type = "Lion";

            // Call the methods
            lion.Eat();
            lion.Sleep();

            // Print the object details using the ToString() method
            Console.WriteLine(lion.ToString());

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}