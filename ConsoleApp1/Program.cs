// See https://aka.ms/new-console-template for more information
using System;
namespace DataDemo {
    class Firsthello
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //int b = 20;
            int sum,num1,num2;
            //sum = a + b;

            Console.WriteLine("enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine("The Sum is ");
            Console.WriteLine(sum);
        }

    }
}

