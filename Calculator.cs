using System;
using System.Linq;

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
                        Console.WriteLine(Addition(AskUserFor("first term"), AskUserFor("second term")));
                        break;

                    case 'S':
                    case 's':
                        Console.WriteLine(Subtraction(AskUserFor("minuend"), AskUserFor("subtrahend")));
                        break;

                    case 'D':
                    case 'd':
                        Console.WriteLine(Division(AskUserFor("dividend"), AskUserFor("divisor", true)));
                        break;

                    case 'M':
                    case 'm':
                        Console.WriteLine(Multiplication(AskUserFor("first factor"), AskUserFor("second factor")));
                        break;

                    case 'E':
                    case 'e':
                        Console.WriteLine(Exponentiation(AskUserFor("base"), AskUserFor("exponent")));
                        break;

                    case 'R':
                    case 'r':
                        Console.WriteLine(Radical(AskUserFor("radicand"), AskUserFor("index")));
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

        public static string Addition(double[] terms)
        {
            if (terms.Length >= 2)
            {
                string termsString = string.Join(", ", terms.Select(x => x.ToString()).ToArray());

                return $"The sum of {termsString} is: {terms.Sum()}";
            }
            else
            {
                return "The array must contain at least two elements.";
            }
        }

        public static string Subtraction(double minuend, double subtrahend)
        {
            return $"The difference of {minuend} and {subtrahend} is: {minuend - subtrahend}";
        }

        public static string Subtraction(double[] terms)
        {
            if (terms.Length >= 2)
            {
                string termsString = string.Join(", ", terms.Select(x => x.ToString()).ToArray());

                terms[0] = -terms[0];

                return $"The difference of {termsString} is: {-terms.Sum()}";
            }
            else
            {
                return "The array must contain at least two elements.";
            }
        }

        public static string Division(double dividend, double divisor)
        {
            if (divisor != 0)
            {
                return $"The quotient of {dividend} and {divisor} is: {dividend / divisor}";
            }
            else
            {
                return "Division by zero is not allowed.";
            }
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
                    string stringFromUser;

                    Console.Write($"Enter {description}: ");
                    stringFromUser = Console.ReadLine();
                    stringFromUser = stringFromUser.Replace('.',',');
                    valueFromUser = Convert.ToDouble(stringFromUser);

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
