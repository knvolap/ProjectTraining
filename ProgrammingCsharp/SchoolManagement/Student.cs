using System;

namespace SchoolManagement
{
    public class Student : BaseEntity
    {
        public int GradeLevel { get; set; }

        public Student(string name, int age, int gradeLevel, string address, int phone, string email)
        {
            Name = name;
            Age = age;
            GradeLevel = gradeLevel;            
            Address = address;
            Phone = phone;
            Email = email;
        }
    }
}
