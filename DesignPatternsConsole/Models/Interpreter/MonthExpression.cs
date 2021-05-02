namespace DesignPatternsConsole.Models.Interpreter
{
    public class MonthExpression : IAbstractExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace("MM", context.Date.Month.ToString());
        }
    }
}
