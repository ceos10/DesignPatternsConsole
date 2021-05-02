namespace DesignPatternsConsole.Models.Interpreter
{
    public class YearExpression : IAbstractExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace("YYYY", context.Date.Year.ToString());
        }
    }
}
