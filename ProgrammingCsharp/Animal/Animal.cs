using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Animal
    {
        // Fields
        private string name;
        private int age;
        private string type;

        // Properties
        public string Name
        {
            get => name;
            set => name = value?.Trim();
        }

        public int Age
        {
            get => age;
            set => age = value < 0 ? 0 : value;
        }

        public string Type
        {
            get => type;
            set => type = value?.Trim().ToLower();
        }

        // Methods
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }

        public override string ToString()
        {
            return $"{Name}, {Age}, {Type}";
        }
    }
}