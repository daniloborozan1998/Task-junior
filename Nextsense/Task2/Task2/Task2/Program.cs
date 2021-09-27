using System;

namespace Task2
{
    class Program
    {
        static void Print(int[] array)
        {
            int arraySum, smallest, arr_size = array.Length;
            arraySum = 0;
            smallest = array[0];

            for (int i = 0; i < arr_size; i++)
            {
                
                if (array[i] < smallest)
                    smallest = array[i];

                
                arraySum += array[i];
            }

            int iteration = arraySum - arr_size * smallest;

            Console.WriteLine("============= ANSWER ===============");
            Console.WriteLine("Iteration = " + iteration);
            Console.WriteLine("=============  ===============");
        }
        static void Main(string[] args)
        {
            //int[] array = {5,6,8,8,5 };
            //print(array);
            Console.WriteLine("Please enter number of element in array: ");
            bool success = int.TryParse(Console.ReadLine(), out int numOfElement);
            int[] array = new int[numOfElement];
            if (success)
            {
                for (int i = 0; i < numOfElement; i++)
                {
                    Console.WriteLine($"Element - {i} : ");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                Print(array);
            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.ReadLine();
        }
    }
}
