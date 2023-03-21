using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement
{
    public class Department
    {
        private string Name { get; set; }
        private List<Employee> Employees { get; set; }
        private Department ParentDepartment { get; set; }

        public Department(string name, Department parentDepartment = null)
        {
            Name = name;
            Employees = new List<Employee>();
            ParentDepartment = parentDepartment;
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            Employees.Remove(employee);
        }
    }
}