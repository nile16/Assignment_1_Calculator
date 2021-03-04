using System;

namespace Assignment_1_Calculator
{
    public class Calculator
    {
        public static void Main()
        {
            while (true)
            {
                char userSelection;

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

                userSelection = Console.ReadKey(true).KeyChar;

                Console.Clear();

                if (userSelection == 'x' || userSelection == 'X') break;

                switch (userSelection)
                {
                    case 'A':
                    case 'a':
                        double term1;
                        double term2;

                        term1 = AskUserFor("first term");
                        term2 = AskUserFor("second term");

                        Console.WriteLine(Addition(term1, term2));
                        break;

                    case 'S':
                    case 's':
                        double minuend;
                        double subtrahend;

                        minuend = AskUserFor("minuend");
                        subtrahend = AskUserFor("subtrahend");

                        Console.WriteLine(Subtraction(minuend, subtrahend));
                        break;

                    case 'D':
                    case 'd':
                        double dividend;
                        double divisor;

                        dividend = AskUserFor("dividend");
                        divisor = AskUserFor("divisor", true);

                        Console.WriteLine(Division(dividend, divisor));
                        break;

                    case 'M':
                    case 'm':
                        double factor1;
                        double factor2;

                        factor1 = AskUserFor("first factor");
                        factor2 = AskUserFor("second factor");

                        Console.WriteLine(Multiplication(factor1, factor2));
                        break;

                    case 'E':
                    case 'e':
                        double bas;
                        double exponent;

                        bas = AskUserFor("base");
                        exponent = AskUserFor("exponent");

                        Console.WriteLine(Exponentiation(bas, exponent));
                        break;

                    case 'R':
                    case 'r':
                        double radicand;
                        double index;

                        radicand = AskUserFor("radicand");
                        index = AskUserFor("index");

                        Console.WriteLine(Radical(radicand, index));
                        break;
                }

                Console.WriteLine("\nPress any key to continue");
                Console.ReadKey(true);
            }
        }

        public static string Addition(double term1, double term2)
        {
            return $"The sum of {term1} and {term2} is: {term1 + term2}";
        }

        public static string Subtraction(double minuend, double subtrahend)
        {
            return $"The difference of {minuend} and {subtrahend} is: {minuend - subtrahend}";
        }

        public static string Division(double dividend, double divisor)
        {
            return $"The quotient of {dividend} and {divisor} is: {dividend / divisor}";
        }

        public static string Multiplication(double factor1, double factor2)
        {
            return $"The product of {factor1} and {factor2} is: {factor1 * factor2}";
        }

        public static string Exponentiation(double bas, double exponent)
        {

            return $"The exponentiation of {bas} and {exponent} is: {Math.Pow(bas, exponent)}";
        }

        public static string Radical(double radicand, double index)
        {
            return $"The {index} root of {radicand} is: {Math.Pow(radicand, 1 / index)}";
        }

        private static double AskUserFor(string description, bool rejectZero = false)
        {
            double valueFromUser;

            while (true)
            {
                try
                {
                    Console.Write($"Enter {description}: ");
                    valueFromUser = Convert.ToDouble(Console.ReadLine());

                    if (valueFromUser == 0 && rejectZero)
                    {
                        Console.WriteLine("Zero is not accepted, try again.");
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Input not a number, try again.");
                }
            }

            return valueFromUser;
        }
    }
}
