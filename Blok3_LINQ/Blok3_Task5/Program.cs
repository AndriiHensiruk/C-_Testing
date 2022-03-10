using System;
using System.Collections.Generic;
using System.Linq;

namespace Blok3_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10] { 0, 1, 21, 3, 4, 10, 6, 4, 2, 34 };


            var numQuery = numbers.Where((num1, num2)=>num1<=num2);
                

            foreach (int num in numQuery)
            {
                Console.Write("{0,1} ", num);
            }
        }
    }
}
