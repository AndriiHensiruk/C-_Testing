using System;
using System.Collections.Generic;
using System.Linq;


namespace Blok3_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { 
                "Nissan", 
                "Aston Martin", 
                "Chevrolet", 
                "Alfa Romeo", 
                "Chrysler",
                "Dodge",
                "BMW",
                "Ferrari",
                "Audi",
                "Bentley",
                "Ford",
                "Lexus",
                "Mercedes",
                "Toyota",
                "Volvo",
                "Subaru",
                "Запорожець :)"};

            IEnumerable<string> sequence = cars.Where(p => p.StartsWith("З"));

            foreach (string s in sequence)
                Console.WriteLine(s);
        }
    }
}
