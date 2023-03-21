using System;

namespace HRManagement
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        public Employee(string name, int age, string department, double salary)
        {
            Name = name;
            Age = age;
            Department = department;
            Salary = salary;
        }
    }
}
