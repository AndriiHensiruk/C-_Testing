using System;
using System.Collections.Generic;
using System.Linq;


namespace Blok3_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10] { 0, 1, 2, 3, 4, 5, 6, 4, 2, 34 };


            var numQuery =
                from num in numbers
                where (num * num) < 20
                select num;

            foreach (int num in numQuery)
            {
                Console.Write("{0,1} ", num);
            }
        }
    }
}
