using DesignPatternsConsole.Models.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsConsole.Logic.Behavioral
{
    public class InterpreterPattern : IPattern
    {
        public void RunExample()
        {
            List<IAbstractExpression> expressions = new List<IAbstractExpression>();
            
            //select expression: MM DD YYYY or YYYY MM DD or DD MM YYYY
            Context context = new Context(DateTime.Now)
            {
                Expression = "MM DD YYYY"
            };

            string[] strArray = context.Expression.Split(' ');
            
            foreach (var item in strArray)
            {
                if (item == "DD")
                {
                    expressions.Add(new DayExpression());
                }
                else if (item == "MM")
                {
                    expressions.Add(new MonthExpression());
                }
                else if (item == "YYYY")
                {
                    expressions.Add(new YearExpression());
                }
            }

            expressions.Add(new SeparatorExpression());

            foreach (var obj in expressions)
            {
                obj.Evaluate(context);
            }

            Console.WriteLine(context.Expression);
        }
    }
}
