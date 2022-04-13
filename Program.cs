using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); // dotnet run
            // Exercise 5
            Space();
            AskExercise();

        }

        public static void Space()
        {
            System.Console.WriteLine();
        }

        public static void AskExercise()
        {
            Space();
            Console.WriteLine("Which Exercise ? \n1) User Input\n2) Basic Maths\n3) Swap Variables");
            var exerciseInput = Console.ReadLine();
            int valueInput = int.Parse(exerciseInput);
            switch (valueInput)
            {
                case 1:
                    InputExercise();
                    AskExercise();
                    break;
                case 2:
                    BasicMaths();
                    AskExercise();
                    break;
                case 3:
                    SwapVariable();
                    SecondSwap();
                    AskExercise();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    AskExercise();
                    break;
            }
        }

        public static void BasicMaths()
        {
            Sum();
            Divide();
            MoreMaths();
        }

        public static void Sum()
        {
            System.Console.WriteLine("Sum:");
            System.Console.WriteLine(15+17);
            Space();
        }

        public static void Divide()
        {
            System.Console.WriteLine("Divide:");
            System.Console.WriteLine(36/6);
            Space();
        }

        public static void MoreMaths()
        {
            int num1 = -1 + 4 * 6;
            int num2 = (35 + 5) % 7;
            double num3 = 14 + -4 * 6 / 11;
            double num4 = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine($"{num1}\n{num2}\n{num3}\n{num4}");
        }

        public static void InputExercise()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
            Space();
        }

        public static void SwapVariable()
        {
            int number1, number2, temp;
            Console.Write("\nInput the First Number : ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("\nInput the Second Number : ");
            number2 = int.Parse(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " +number1);
            Console.Write("\nSecond Number : " +number2);
            // Console.Read();
            Space();
        }

        public static void SecondSwap()
        {
            Space();
            Console.WriteLine("First Number");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Number");
            int B = Convert.ToInt32(Console.ReadLine());
            int SWAP1 = A;
            int SWAP2 = B;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("THE FIRST NUMBER IS " + A);
            Console.WriteLine("THE SECOND NUMBER IS " + B);
            Console.WriteLine("---------------------------\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("AFTER SWAPPING: \n");
            Console.WriteLine("FIRST NUMBER IS " + SWAP2);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("SECOND NUMBER IS " + SWAP1);
            ColorReset();
            Space();
        }

        public static void ColorReset()
        {
            Console.ResetColor();
        }
    }
}
