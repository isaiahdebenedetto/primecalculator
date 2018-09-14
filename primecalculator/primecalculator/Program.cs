using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primecalculator
{
    class Program
    {
        static String operand;
        static string input;
        static double result, num1, num2;
        static int k;

        static void Main(string[] args)
        {
            HelpMenu help = new HelpMenu();
            help.PromptMenu();
        }
    }

    class HelpMenu
    {
        public Calculator calc;
        private const string help = "/help";
        public string input;

        //constructor
        public HelpMenu()
        {
            //initialize calc object
            calc = new Calculator();
        }

        //ask user for help
        public void PromptMenu()
        {
            Console.WriteLine("type /help for a list of options... ");
            input = (Console.ReadLine());
            switch (input)
            {
                case "/help":
                    PromptHelpMenu();
                    break;
                default: //recursively prompt menu
                    PromptMenu();
                    break;
            }
        }

        //ask user for help
        public void PromptHelpMenu()
        {
            Console.WriteLine("1. Calculator\n2. Calculate Prime\n3. Calculate Factorial\n4. Calculate Fibonacci");

            input = (Console.ReadLine());
            switch (input)
            {
                case "1": //call calclator function
                    calc.PromptFirstNumber();
                    calc.PromptOperand();
                    calc.PromptSecondNumber();
                    calc.DisplayAnswer();
                    break;
                case "2": //call prime check function
                    calc.CalculatePrime();
                    break;
                case "3":
                    calc.CalculateFactorial();
                    break;
                case "4":
                    calc.CalculateFib();
                    break;
                default: //recursively prompt menu
                    PromptMenu();
                    break;
            }
        }
    }

    class Calculator
    {
        public string operand;
        public double result, num1, num2;
        public int k, len;

        public Calculator()
        {
            k = 0;
        }

        public void PromptFirstNumber()
        {
            //get first number
            Console.WriteLine("Please enter a number");
            num1 = Convert.ToInt32(Console.ReadLine());
        }

        public void PromptOperand()
        {
            //get operation
            Console.WriteLine("Which operation would you like to use (+,-,*,/)?");
            operand = Convert.ToString(Console.ReadLine());
        }

        public void PromptSecondNumber()
        {
            //get second number
            Console.WriteLine("Please enter a second number");
            num2 = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayAnswer()
        {
            switch (operand)
            {
            //calculate answer
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    result = 0;
                    break;
            }
            
            //display answer
            Console.WriteLine("The answer is: " + num1.ToString() + " " + operand + " " + num2.ToString() + " = " + result.ToString());
            Console.ReadKey();
        }

        public void CalculatePrime()
        {

            Console.Write("Enter a number: ");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    k++;
                }
            }
            if (k == 2)
            {
                Console.WriteLine("Entered Number is a Prime Number and the Largest factor is {0}", num);
            }
            else
            {
                Console.WriteLine("Not a prime number");
            }
            Console.ReadLine();
        }

        public void CalculateFactorial()
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            long fact = GetFactorial(number);
            Console.WriteLine("{0} factorial is {1}", number, fact);
            Console.ReadKey();
        }

        private static long GetFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * GetFactorial(number - 1);
        }

        public static void CalculateFib(int len)
        {
            
            Fibonacci_Rec_Temp(0, 1, 1, len);
        }

        private static void Fibonacci_Rec_Temp(int a, int b, int counter, int len)
        {
            if (counter <= len)
            {
                Console.Write("{0}", a);
                Fibonacci_Rec_Temp(b, a + b, counter + 1, len);
            }
        }
        public void Retry()
        {
            //TODO: prompt to restart program
        }
    }
}
