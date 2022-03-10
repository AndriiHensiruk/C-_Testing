//Blok1_task2
using System;

namespace blok1_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter the number for the multiplication plate");

                uint Value = uint.Parse(Console.ReadLine());

                for(int i=0; i<=10; i++)
                {
                    Console.WriteLine(i + "*" + Value + "=" + Value*i);
                }

                Console.ReadLine();
            }

        }
    }
}
