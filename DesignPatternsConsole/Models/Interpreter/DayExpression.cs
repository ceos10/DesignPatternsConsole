namespace DesignPatternsConsole.Models.Interpreter
{
    public class DayExpression : IAbstractExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace("DD", context.Date.Day.ToString());
        }
    }
}
