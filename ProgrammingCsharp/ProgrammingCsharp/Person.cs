using System;

namespace DefiningClasses
{
    public class Person
    {
        // Fields (also known as instance variables)
        private string name;
        private int age;

        // Constructor (a special method that is called when an object is created)
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Methods
        public void SayHello()
        {
            Console.WriteLine($"Hello, my name is {name} and I'm {age} years old.");
        }

        // Properties (allow you to access and modify fields outside the class)
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}