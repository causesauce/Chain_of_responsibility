using Calculator.Chain;
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            var calculator = new Calculator();
            var a = 2;
            var b = 300;
            var result = calculator.Calculate($"{a} + {b}");
            Console.WriteLine("----------------------------");
            Console.WriteLine(result);
            Console.WriteLine("----------------------------");
            result = calculator.Calculate($"{a} - {b}");
            Console.WriteLine(result);
            Console.WriteLine("----------------------------");
            result = calculator.Calculate($"{a} * {b}");
            Console.WriteLine(result);
            Console.WriteLine("----------------------------");
            result = calculator.Calculate($"{a} / {b}");
            Console.WriteLine(result);
            Console.WriteLine("----------------------------");
            result = calculator.Calculate($"{a} dwqdqw {b}");
            Console.WriteLine(result);
            Console.WriteLine("----------------------------");
        }
    }
}
