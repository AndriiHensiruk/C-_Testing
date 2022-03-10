using System;
using System.Collections.Generic;

namespace Blok2_task1
{
    public class Person
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public int age { get; set; }
    }

    public class Student : Person
    {
        public Student()
        {

        }
    }

    public class Teacher : Person
    {
        public Teacher(int id, string firstName, string lastName, string middleName, int age)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.middleName = middleName;
            this.age = age;

        }
    }

    class Group
    {
        public List<Student> students { get; set; }

        public List<Teacher> teachers { get; set; } = new List<Teacher>();

        public Group()
        {
           students = new List<Student>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group();

           
            group.students.Add(new Student() { id=1, firstName="Adams", lastName="sdfgdg", middleName="dgertg", age=12 });
            //group.students.Add(new Student(1, "Baker", "sdfgdg", "dgertg", 19));
            //group.students.Add(new Student(1, "Clark", "sdfgdg", "dgertg", 16));
            //group.students.Add(new Student(1, "wretty", "sdfgdg", "dgertg", 15));

           group.teachers.Add(new Teacher(1, "Afghfd", "Dfghjfg", "Egfj", 45));

            Console.WriteLine("List of students");

            foreach (Student student in group.students)
            {
                Console.WriteLine(student.firstName+" "+student.lastName+" "+student.middleName+" "+student.age);
            

            Console.WriteLine("Group leader");
            foreach (Teacher teacher in group.teachers)
              Console.WriteLine(teacher.firstName + " " + teacher.lastName + " " + teacher.middleName + " " + teacher.age);
        }
    }
}
