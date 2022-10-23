using System;
using Tools;

namespace ConsoleHelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = Calculator.Div(3, 2);
            Console.WriteLine(result);
        }
    }
}