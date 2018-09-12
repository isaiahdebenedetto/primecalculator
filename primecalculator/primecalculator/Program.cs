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
        static string menu;
        static double result, num1, num2;
        static int k;

        static void Main(string[] args)
        {
            HelpMenu help = new HelpMenu();
            help.PromptMenu();

            Calculator calc = new Calculator();
            calc.PromptFirstNumber();
            calc.PromptOperand();
            calc.PromptSecondNumber();
            calc.DisplayAnswer();
            calc.CalculatePrime();
        }
    }

    class HelpMenu
    {
        private const string help = "/help";
        public string menu;

        public string PromptMenu()
        {
            Console.WriteLine("type /help for a list of options... ");
            
            }
        }
    }

    class Calculator
    {
        public string operand;
        public double result, num1, num2;
        public int k;

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

        public void Retry()
        {
            //TODO: prompt to restart program
        }
    }
}
