// Blok1_task3

using System;

namespace blok1_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in the array:\t");
            int elementsCouunt = int.Parse(Console.ReadLine());
            int[] myArray = new int[elementsCouunt];

            for (int i=0; i<myArray.Length; i++)
            {
                Console.Write($"\n Enter the element of the array {i} :\t");
                myArray[i] = int.Parse(Console.ReadLine());
            }

           
            int sumArray=0, counter=0;
            double arithmeticMean;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] >= 0)
                    {
                    counter++;
                    sumArray = sumArray + myArray[i];
                     }
            }

            arithmeticMean = sumArray / counter;

            Console.Write("Arithmetic mean :"+ arithmeticMean);
        }
    }
}
