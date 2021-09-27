using System;
using System.Diagnostics;

namespace Task1Solution2
{
    class Program
    {
        public static void AllQuestions()
        {
            Console.WriteLine("Question");
            Console.WriteLine("==============");
            Console.WriteLine("1) First Question ");
            Console.WriteLine("2) Second Question ");
            Console.WriteLine("3) Third Question ");
            Console.WriteLine("4) Fourth Question");
            Console.WriteLine("5) Fifth Question ");
            Console.WriteLine("6) Sixth Question ");
            Console.WriteLine("7) Seventh Question ");
            Console.WriteLine("8) Eighth Question ");
        }
        public static void Question()
        {
            Console.WriteLine("Answer the question");
            Console.WriteLine("==============");
            Console.WriteLine("1) First Answer ");
            Console.WriteLine("2) Second Answer ");
            Console.WriteLine("3) Third Answer ");
            Console.WriteLine("4) Fourth Answer");
           
        }
        
        public static void print(int[][] array)
        {
            if (array[0][0] > 5 || array[0][1] > 5 || array[0][2] > 10 || array[0][3] > 10 || array[0][4] > 15 || array[0][5] > 15 || array[0][6] > 20 || array[0][7] > 20)
            {
                Console.WriteLine("==================");
                Console.WriteLine("Disqualified");
                Console.WriteLine("==================");

            }
            else if (array[0][0] < 5 && array[0][1] < 5 && array[0][2] < 10 && array[0][3] < 10 && array[0][4] < 15 && array[0][5] < 15 && array[0][6] < 20 && array[0][7] < 20)
            {
                Console.WriteLine("==================");
                Console.WriteLine("Qualified");
                Console.WriteLine("==================");
            }
            else if (array[1][0] > 120)
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

            }


        }
        static void Main(string[] args)
        {
            int sum = 0;
            
            AllQuestions();
            bool flag = true;
            while (flag)
            {
                int time = 0;
                bool success = int.TryParse(Console.ReadLine(), out int option);
                if (success)
                {

                    if (option < 1 || option > 8)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong input.. Try again ");
                        Console.ResetColor();
                        Console.Clear();
                        AllQuestions();
                    }

                    if (option == 1)
                    {
                        Console.Clear();
                        Question();
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        Console.WriteLine("Time is started...");
                        bool success1 = int.TryParse(Console.ReadLine(), out int option1);
                        if (success1)
                        {
                            if (option1 < 1 || option1 > 4)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Wrong input.. Try again ");
                                Console.ResetColor();
                                Console.Clear();
                                AllQuestions();
                            }

                            if (option1 == 1 || option1 == 2 || option1 == 3 || option1 == 4)
                            {
                                stopwatch.Stop();
                                TimeSpan stopwatchElapsed = stopwatch.Elapsed;
                                Console.WriteLine("===========================");
                                Console.WriteLine($"Your time for answer is {Convert.ToInt32(stopwatchElapsed.TotalSeconds)} seconds");
                                time = Convert.ToInt32(stopwatchElapsed.TotalSeconds);
                            }

                        }
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        AllQuestions();
                    }else if (option == 2)
                    {
                        Console.Clear();
                        Question();
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        Console.WriteLine("Time is started...");
                        bool success1 = int.TryParse(Console.ReadLine(), out int option1);
                        if (success1)
                        {
                            if (option1 < 1 || option1 > 4)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Wrong input.. Try again ");
                                Console.ResetColor();
                                Console.Clear();
                                AllQuestions();
                            }

                            if (option1 == 1 || option1 == 2 || option1 == 3 || option1 == 4)
                            {
                                stopwatch.Stop();
                                TimeSpan stopwatchElapsed = stopwatch.Elapsed;
                                Console.WriteLine("===========================");
                                Console.WriteLine($"Your time for answer is {Convert.ToInt32(stopwatchElapsed.TotalSeconds)} seconds");
                                time = Convert.ToInt32(stopwatchElapsed.TotalSeconds);
                            }

                        }
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        AllQuestions();
                    }
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            
        }
    }
}
