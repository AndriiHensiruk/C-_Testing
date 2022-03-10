// Blok1_task1
using System;

namespace Blok1_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");

            string name;
            name = Console.ReadLine();

            Console.WriteLine("Нi " + name);

            Console.WriteLine("Enter your age");

            string age;
            age = Console.ReadLine();
            int date = Convert.ToInt32(age);

            int year = 2022 - date;
            Console.WriteLine(name + " you were born in " + year);
        }
    }
}
