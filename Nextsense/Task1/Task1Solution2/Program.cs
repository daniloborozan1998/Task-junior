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
            Console.WriteLine("9) Finish ");
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

        public static void Print(int[][] array)
        {
            if (array[0][1] == 0 || array[0][2] == 0 || array[0][3] == 0 || array[0][4] == 0 || array[0][5] == 0 || array[0][6] == 0 || array[0][7] == 0)
            {
                Console.WriteLine("==================");
                Console.WriteLine("Disqualified");
                Console.WriteLine("==================");
            }else if (array[0][0] > 5 || array[0][1] > 5 || array[0][2] > 10 || array[0][3] > 10 || array[0][4] > 15 ||
                      array[0][5] > 15 || array[0][6] > 20 || array[0][7] > 20)
            {
                Console.WriteLine("==================");
                Console.WriteLine("Disqualified");
                Console.WriteLine("==================");

            }
            else if (array[0][0] < 5 && array[0][1] < 5 && array[0][2] < 10 && array[0][3] < 10 && array[0][4] < 15 &&
                     array[0][5] < 15 && array[0][6] < 20 && array[0][7] < 20)
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

        public static void Answer()
        {
            int[][] array = new int[2][];
            array[0] = new int[8];
            array[1] = new int[1];
            int sum = 0;
            AllQuestions();
            bool flag = true;
            while (flag)
            {

                bool success = int.TryParse(Console.ReadLine(), out int option);
                if (success)
                {

                    if (option < 1 || option > 9)
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
                                Console.WriteLine($"Your time for answer is {Convert.ToInt32(stopwatchElapsed.TotalMinutes)} min");
                                //Console.WriteLine($"Your time for answer is {Convert.ToInt32(stopwatchElapsed.TotalSeconds)} min");
                                //array[0][1] = Convert.ToInt32(stopwatchElapsed.TotalSeconds);
                                array[0][1] = Convert.ToInt32(stopwatchElapsed.TotalMinutes);
                                sum += array[0][1];
                                array[1][0] = sum;

                            }

                        }
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        AllQuestions();
                    }
                    else if (option == 2)
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
                                Console.WriteLine($"Your time for answer is {Convert.ToInt32(stopwatchElapsed.TotalMinutes)} min");
                                //Console.WriteLine($"Your time for answer is {Convert.ToInt32(stopwatchElapsed.TotalSeconds)} min");
                                //array[0][2] = Convert.ToInt32(stopwatchElapsed.TotalSeconds);
                                array[0][2] = Convert.ToInt32(stopwatchElapsed.TotalMinutes);
                                sum += array[0][2];
                                array[1][0] = sum;
                            }

                        }
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        AllQuestions();
                    }
                    else if (option == 3)
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
                                Console.WriteLine($"Your time for answer is {Convert.ToInt32(stopwatchElapsed.TotalMinutes)} min");
                                //Console.WriteLine($"Your time for answer is {Convert.ToInt32(stopwatchElapsed.TotalSeconds)} min");
                                //array[0][3] = Convert.ToInt32(stopwatchElapsed.TotalSeconds);
                                array[0][3] = Convert.ToInt32(stopwatchElapsed.TotalMinutes);
                                sum += array[0][3];
                                array[1][0] = sum;
                            }

                        }
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        AllQuestions();
                    }
                    else if (option == 4)
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
                                Console.WriteLine($"Your time for answer is {Convert.ToInt32(stopwatchElapsed.TotalMinutes)} min");
                                //Console.WriteLine($"Your time for answer is {Convert.ToInt32(stopwatchElapsed.TotalSeconds)} min");
                                //array[0][4] = Convert.ToInt32(stopwatchElapsed.TotalSeconds);
                                array[0][4] = Convert.ToInt32(stopwatchElapsed.TotalMinutes);
                                sum += array[0][4];
                                array[1][0] = sum;
                            }

                        }
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        AllQuestions();
                    }
                    else if (option == 5)
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
                                Console.WriteLine($"Your time for answer is {Convert.ToInt32(stopwatchElapsed.TotalMinutes)} min");
                                //Console.WriteLine($"Your time for answer is {Convert.ToInt32(stopwatchElapsed.TotalSeconds)} min");
                                //array[0][5] = Convert.ToInt32(stopwatchElapsed.TotalSeconds);
                                array[0][5] = Convert.ToInt32(stopwatchElapsed.TotalMinutes);
                                sum += array[0][5];
                                array[1][0] = sum;
                            }

                        }
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        AllQuestions();
                    }
                    else if (option == 6)
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
                                Console.WriteLine($"Your time for answer is {Convert.ToInt32(stopwatchElapsed.TotalMinutes)} min");
                                //Console.WriteLine($"Your time for answer is {Convert.ToInt32(stopwatchElapsed.TotalSeconds)} min");
                                //array[0][6] = Convert.ToInt32(stopwatchElapsed.TotalSeconds);
                                array[0][6] = Convert.ToInt32(stopwatchElapsed.TotalMinutes);
                                sum += array[0][6];
                                array[1][0] = sum;
                            }

                        }
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        AllQuestions();
                    }
                    else if (option == 7)
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
                                Console.WriteLine($"Your time for answer is {Convert.ToInt32(stopwatchElapsed.TotalMinutes)} min");
                                //Console.WriteLine($"Your time for answer is {Convert.ToInt32(stopwatchElapsed.TotalSeconds)} min");
                                array[0][7] = Convert.ToInt32(stopwatchElapsed.TotalMinutes);
                                //array[0][7] = Convert.ToInt32(stopwatchElapsed.TotalSeconds);
                                sum += array[0][7];
                                array[1][0] = sum;
                            }

                        }
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        AllQuestions();
                    }
                    else if (option == 8)
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
                                Console.WriteLine($"Your time for answer is {Convert.ToInt32(stopwatchElapsed.TotalMinutes)} min");
                                //Console.WriteLine($"Your time for answer is {Convert.ToInt32(stopwatchElapsed.TotalSeconds)} min");
                                //array[0][8] = Convert.ToInt32(stopwatchElapsed.TotalSeconds);
                                array[0][8] = Convert.ToInt32(stopwatchElapsed.TotalMinutes);
                                sum += array[0][8];
                                array[1][0] = sum;
                            }

                        }
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        AllQuestions();
                    }
                    else if (option == 9)
                    {
                        Console.Clear();
                        Console.ResetColor();
                        Console.WriteLine($"Time for all question: {sum}");
                        Print(array);
                        flag = false;
                    }
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }


        static void Main(string[] args)
        {
            Answer();
        }
    }
}
