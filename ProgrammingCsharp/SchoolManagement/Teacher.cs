using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    public class Teacher : BaseEntity
    {    
        public string Subject { get; set; }
        public Teacher(string name, int age, string subject, string address, int phone, string email)
        {
            Name = name;
            Age = age;
            Subject = subject;
            Address = address;
            Phone = phone;
            Email = email;
        }
    }
}
