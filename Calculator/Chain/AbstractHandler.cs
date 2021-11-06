using Calculator.Chain.Interfaces;

namespace Calculator.Chain
{
    public class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;
        
        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;

            return handler;
        }

        public virtual object Handle(object request)
        {
            if(this._nextHandler != null)
            {
                return this._nextHandler.Handle(request);
            }
            else
            {
                return $"{this.GetType().Name} responses: give string is not correct, should be in a given format: " +
                    $"a+b OR a + b OR a + (-b) OR a+(-b).\ninstead of + there could be used -, *, / operands.\ndivision by zero is forbidden.";
            }
        }
    }
}
