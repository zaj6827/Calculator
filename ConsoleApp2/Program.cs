using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum;
            string operat;
            int secondNum;
            int answer;

            Console.WriteLine("Welcome to the Calculator. Please enter a number");
            Console.Write("Enter your first number");
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your operation (*, /, +, or -)");
            operat = Console.ReadLine();
            Console.Write("Enter your second number");
            secondNum = Convert.ToInt32(Console.ReadLine());
            switch (operat)
            {
                    case "*":
                        answer = firstNum * secondNum;
                    Console.WriteLine(answer);
                    break;
                    case "/":
                        answer = firstNum / secondNum;
                    Console.WriteLine(answer);
                    break;
                    case "+":
                        answer = firstNum + secondNum;
                    Console.WriteLine(answer);
                    break;
                    case "-":
                        answer = firstNum - secondNum;
                    Console.WriteLine(answer);
                    break;
            }
            Console.ReadLine();
        }
    }
}
