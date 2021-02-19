using System;

namespace Assignment_1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            char userInput;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Assignment 1, Calculator");
                Console.WriteLine("************************\n");
                Console.WriteLine("Press A for Addition");
                Console.WriteLine("Press S for Subtraction");
                Console.WriteLine("Press D for Division");
                Console.WriteLine("Press M for Multiplication");
                Console.WriteLine("Press E for Exponentiation");
                Console.WriteLine("Press R for Radical\n");
                Console.WriteLine("Press X to exit program");
                userInput = Console.ReadKey(true).KeyChar;
                Console.Clear();

                switch (userInput)
                {
                    case 'A':
                    case 'a':
                        Addition();
                        break;

                    case 'S':
                    case 's':
                        Subtraction();
                        break;

                    case 'D':
                    case 'd':
                        Division();
                        break;

                    case 'M':
                    case 'm':
                        Multiplication();
                        break;

                    case 'E':
                    case 'e':
                        Exponentiation();
                        break;

                    case 'R':
                    case 'r':
                        Radical();
                        break;
                }

                if (userInput == 'x' || userInput == 'X') break;

                Console.WriteLine("\nPress any key to continue");
                Console.ReadKey(true);
            }
        }

        private static void Addition()
        {
            double t1;
            double t2;

            t1 = AskUserFor("first term");
            t2 = AskUserFor("second term");

            Console.WriteLine($"\nThe sum of {t1} and {t2} is: {t1 + t2}");
        }

        private static void Subtraction()
        {
            double m;
            double s;

            m = AskUserFor("minuend");
            s = AskUserFor("subtrahend");

            Console.WriteLine($"\nThe difference of {m} and {s} is: {m - s}");
        }

        private static void Division()
        {
            double dd;
            double dr;

            dd = AskUserFor("dividend");
            dr = AskUserFor("divisor", true);

            Console.WriteLine($"\nThe quotient of {dd} and {dr} is: {dd / dr}");
        }

        private static void Multiplication()
        {
            double f1;
            double f2;

            f1 = AskUserFor("first factor");
            f2 = AskUserFor("second factor");

            Console.WriteLine($"\nThe product of {f1} and {f2} is: {f1 * f2}");
        }

        private static void Exponentiation()
        {
            double b;
            double e;

            b = AskUserFor("base");
            e = AskUserFor("exponent");

            Console.WriteLine($"\nThe exponentiation of {b} and {e} is: {Math.Pow(b, e)}");
        }

        private static void Radical()
        {
            double r;
            double i;

            r = AskUserFor("radicand");
            i = AskUserFor("index");

            Console.WriteLine($"\nThe {i} root of {r} is: {Math.Pow(r, 1/i)}");
        }

        private static double AskUserFor(string description, bool rejectZero = false)
        {
            double value;

            Console.Write($"Enter {description}: ");
 
            while (true)
            {
                try
                {
                    value = Convert.ToDouble(Console.ReadLine());

                    if (value == 0 && rejectZero)
                    {
                        Console.Write("Zero is not accepted, try again: ");
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.Write("Invalid input, try again: ");
                }
            }

            return value;
        }
    }
}
