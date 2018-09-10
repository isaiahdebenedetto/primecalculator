using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primecalculator
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Calculator

            String operand;
            double result, num1, num2;
            //int k;
            //k = 0;

            //get first number
            Console.WriteLine("Please enter a number");
            num1 = Convert.ToInt32(Console.ReadLine());

            //get operation
            Console.WriteLine("Which operation would you like to use (+,-,*,/)?");
            operand = Convert.ToString(Console.ReadLine());

            //get second number
            Console.WriteLine("Please enter a second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            //calculate equation
            switch (operand)
            {
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

            //prime calculator

            //Console.Write("Enter a number: ");
            //int num;
            //num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Test if prime number? (Y/N) ");

           // String answer;
             
            //switch (answer)
            //{
            //    case "y":
            //        answer = "y";
                    //for (int i = 1; i <= result; i++)
                    //{
                    //    if (result % i == 0)
                    //    {
                    //        k++;
                    //    }
                    //}
                    //if (k == 2)
                    //{
                    //    Console.WriteLine("Entered Number is a Prime Number and the Largest factor is {0}", result);
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Not a prime number");
                    //}
                    //Console.ReadLine();
                //    break;
                //case "n":
                //    answer = "n";
                    //Console.WriteLine("End.");
                //    break;

                //default:
                //    answer = "NA";
                //    break;
            }
            
            
            //for (int i = 1; i <= result; i++)
            //{
            //    if (result % i == 0)
            //    {
            //        k++;
            //    }
            //}
            //if (k == 2)
            //{
            //    Console.WriteLine("Entered Number is a Prime Number and the Largest factor is {0}", result);
            //}
            //else
            //{
            //    Console.WriteLine("Not a prime number");
            //}
            //Console.ReadLine();
        }
    }
