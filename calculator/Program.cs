using System;
namespace SimpleAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number:");
            int num2 = int.Parse(Console.ReadLine()); ;
            int sum = addition.Add(num1, num2);
            Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
        }
        class addition
        {
            public static int Add(int a, int b)
            {
                return a + b;
            }
        }
    }
}