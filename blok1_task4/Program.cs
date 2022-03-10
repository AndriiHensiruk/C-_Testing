//blok1_task4

using System;

namespace blok1_task4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the size of the triangle:\n");
            uint sizeTriangle = uint.Parse(Console.ReadLine());

            Console.WriteLine("Pascal Triangle Program");
            for (int i = 0; i < sizeTriangle; i++)
            {
                int c = 1;
                for (  int j = 0; j < sizeTriangle - i; j++)
                    Console.Write(" ");
                for (int q = 0; q <= i; q++)
                    {
                        Console.Write(" {0:D} ", c);
                        c = c * (i - q) / (q + 1);
                    }
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
