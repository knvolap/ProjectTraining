using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement
{
    public class HRStaff
    {
        private string Name { get; set; }
        private int Age { get; set; }
        private List<Department> Departments { get; set; }

        public HRStaff(string name, int age)
        {
            Name = name;
            Age = age;
            Departments = new List<Department>();
        }

        public void AddDepartment(Department department)
        {
            Departments.Add(department);
        }

        public void RemoveDepartment(Department department)
        {
            Departments.Remove(department);
        }

        public void UpdateEmployeeSalary(Employee employee, double newSalary)
        {
            employee.Salary = newSalary;
        }
    }
}
