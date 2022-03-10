// Blok1_task5

using System;
using System.Linq;

namespace Blok1_task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in the array:\t");
            int elementsCouunt = int.Parse(Console.ReadLine());
            int[] myArray = new int[elementsCouunt];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"\n Enter the element of the array {i} :\t");
                myArray[i] = int.Parse(Console.ReadLine());
            }

          int[] result = myArray.Distinct().ToArray();

            Console.Write("Unique elements in the array:\t");
            for (int i=0; i<result.Length; i++)
                Console.Write(result[i]+" ");

        }
    }
}
