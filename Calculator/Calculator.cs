using Calculator.Chain;
using Calculator.Chain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        IHandler OperationsHandler;
        
        public Calculator()
        {
            var add = new AddHandler();
            var divide = new DivideHandler();
            var subtract = new SubtractHandler();
            var multiply = new MultiplyHandler();

            add.SetNext(divide).SetNext(subtract).SetNext(multiply);
            OperationsHandler = add;
        }

        public object Calculate(object request)
        {
            return OperationsHandler.Handle(request);
        }
    }
}
