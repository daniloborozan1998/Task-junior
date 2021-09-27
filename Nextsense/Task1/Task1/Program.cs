using System;
using System.Diagnostics;



namespace Task1
{
    class Program
    {
        public static void Print(int[][] array)
        {
            if (array[0][0] > 5 || array[0][1] > 5 || array[0][2] > 10 || array[0][3] > 10 || array[0][4] > 15 || array[0][5] > 15 || array[0][6] > 20 || array[0][7] > 20)
            {
                Console.WriteLine("==================");
                Console.WriteLine("Disqualified");
                Console.WriteLine("==================");

            }else if (array[0][0] < 5 && array[0][1] < 5 && array[0][2] < 10 && array[0][3] < 10 && array[0][4] < 15 && array[0][5] < 15 && array[0][6] < 20 && array[0][7] < 20)
            {
                Console.WriteLine("==================");
                Console.WriteLine("Qualified");
                Console.WriteLine("==================");
            }else if (array[1][0] > 120)
            {
                
                Console.WriteLine("==================");
                Console.WriteLine("Disqualified");
                Console.WriteLine("==================");
            }
            else if (array[1][0] < 120)
            {
                Console.WriteLine("==================");
                Console.WriteLine("Qualified");
                Console.WriteLine("==================");
            }else if (array[0][1] != 0 || array[0][2] != 0 || array[0][3] != 0 || array[0][4] != 0 || array[0][5] != 0 || array[0][6] != 0 || array[0][7] != 0)
            {
                Console.WriteLine("==================");
                Console.WriteLine("Disqualified");
                Console.WriteLine("==================");
            }


        }
        public static void Main(string[] args)
        {
            int [][] array = new int[2][];
            array[0] = new int[8];
            array[1] = new int[1];
            int sum = 0;
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"Element - {i} : ");
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                Console.WriteLine("Time is started... \nWhen you have answered the question, press Enter");
                string enter = Console.ReadLine();
                if (enter == "")
                {
                    stopwatch.Stop();
                    TimeSpan stopwatchElapsed = stopwatch.Elapsed;
                    Console.WriteLine("===========================");
                    //Console.WriteLine($"Your time for question is {Convert.ToInt32(stopwatchElapsed.TotalSeconds)} sec");
                    Console.WriteLine($"Your time for question is {Convert.ToInt32(stopwatchElapsed.TotalMinutes)} min");
                    Console.WriteLine("===========================");
                    //array[0][i] = Convert.ToInt32(stopwatchElapsed.TotalSeconds);
                    array[0][i] = Convert.ToInt32(stopwatchElapsed.TotalMinutes);
                    sum += array[0][i];
                    array[1][0] = sum;
                    
                }
                
            }
            //Console.WriteLine(sum);
            Print(array);

            Console.ReadLine();
        }
    }
}
