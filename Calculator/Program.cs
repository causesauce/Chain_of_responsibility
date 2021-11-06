using Calculator.Chain;
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var add = new AddHandler();
            var divide = new DivideHandler();
            var subtract = new SubtractHandler();
            var multiply = new MultiplyHandler();

            var example = "1 + (-10)";
            add.SetNext(divide).SetNext(subtract).SetNext(multiply);
            var result = add.Handle(example);
            Console.WriteLine(result);
        }
    }
}
