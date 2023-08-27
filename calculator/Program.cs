using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string answer;
            int result;
            Console.WriteLine("Hello, Welcome to the calculator!");
            while (true)
            {
                Console.WriteLine("Enter your First number: ");

                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your Second number: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What type of operation would you like to do?");
                Console.WriteLine("Please enter a for addition, s for subtraction, m for multiplication and d for division: ");

                answer = Console.ReadLine();

                if (answer == "a")
                {
                    result = num1 + num2;
                }
                else if (answer == "s")
                {
                    result = num1 - num2;
                }
                else if (answer == "m")
                {
                    result = num1 * num2;
                }
                else
                {
                    result = num1 / num2;
                }

                Console.WriteLine("The Result is " + result);
            }            
            Console.WriteLine("Thank you for using the calculator. Please comeback");
            Console.ReadKey();

        }
    }
}
