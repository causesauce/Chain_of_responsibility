using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator.Chain
{
    public class SubtractHandler : AbstractHandler
    {
        private readonly string _pattern = @"-?\d{1,} ?\- ?(\(\-\d{1,}\)|(\d))";//@"\d{1,} ?\- ?\d{1,}";
        private Regex _regex;

        public SubtractHandler()
        {
            _regex = new Regex(_pattern);
        }

        public override object Handle(object request)
        {
            var data = request as string;
            if (_regex.IsMatch(data))
            {
                var text = data.Replace("(", "").Replace(")", "").Trim().Split("-", 2);
                var a = Int32.Parse(text[0]);
                var b = Int32.Parse(text[1]);
                return $"{this.GetType().Name} responses: {a - b}";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
