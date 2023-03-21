using System;

namespace SchoolManagement
{
    class Program
    {
        private static void Main(string[] args)
        {
            // create some students and a teacher
            var alice = new Student("Alice", 15, 10, "Quy Nhon", 123333, "Alice@example.com");
            var bob = new Student("Bob", 15, 10, "Quy Nhon", 44444, "Bob@example.com");
            var mata = new Student("Mata", 15, 10, "Quy Nhon", 7777, "mata@example.com");
            var charlie = new Teacher("Charlie", 35, "Math", "Quy Nhon", 55555, "Charlie@example.com");

            // create a course and add some students
            var mathCourse = new Course("Math", charlie);
            mathCourse.AddStudent(alice);
            mathCourse.AddStudent(bob);
            mathCourse.AddStudent(mata);

            // remove a student from the course
            mathCourse.RemoveStudent(alice);

            // print the remaining students in the course
            foreach (var student in mathCourse.Students)
            {
                Console.WriteLine("ID: " + student.Id);
                Console.WriteLine("Name: " + student.Name);
                Console.WriteLine("\n");
            }
        }
    }
}
