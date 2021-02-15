using System;

namespace CS_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine(); 

            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a number: ");

            if (op == "+")
            {
                Console.Write(num1 + num2);
            } else if (op == "-")
            {
                Console.Write(num1 - num2);
            }
            else if (op == "/")
            {
                Console.Write(num1 / num2);
            }
            else if (op == "*")
            {
                Console.Write(num1 * num2);
            }
            else
            {
                Console.WriteLine("Invaled Operator");
            }

            Console.ReadLine();

        }
    }
}
