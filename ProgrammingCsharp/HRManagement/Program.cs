using System;

namespace HRManagement
{
    abstract class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the employee name:");
            var name = Console.ReadLine();

            Console.WriteLine("Enter the employee department:");
            var department = Console.ReadLine();
            
            Console.WriteLine("Enter the employee age:");
            var age = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Enter the employee salary:");
            var salary = double.Parse(Console.ReadLine() ?? string.Empty);

            var employee = new Employee(name, age, department, salary);

            Console.WriteLine("Enter the operation you want to perform:");
            Console.WriteLine("1. View employee details");
            Console.WriteLine("2. Update employee salary");

            var operation = int.Parse(Console.ReadLine() ?? string.Empty);

            switch (operation)
            {
                case 1:
                    Console.WriteLine($"Name: {employee.Name}");
                    Console.WriteLine($"Department: {employee.Department}");
                    Console.WriteLine($"Salary: {employee.Salary}");
                    break;
                
                case 2:
                    Console.WriteLine("Enter the new salary:");
                    var newSalary = double.Parse(Console.ReadLine() ?? string.Empty);
                    var hrManager = new HRStaff("Jane", 40);
                    hrManager.UpdateEmployeeSalary(employee, newSalary);
                    Console.WriteLine("Salary updated successfully");
                    Console.WriteLine($"New salary: {employee.Name} + {employee.Salary}");
                    break;
                
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
        }
    }
}
