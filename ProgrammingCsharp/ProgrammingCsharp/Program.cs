using System;

namespace DefiningClasses
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var person = new Person("John", 30);
            person.SayHello();
            Console.WriteLine(person.Name); // Output: John
            person.Age = 35;
            Console.WriteLine(person.Age); // Output: 
        }
    }
}