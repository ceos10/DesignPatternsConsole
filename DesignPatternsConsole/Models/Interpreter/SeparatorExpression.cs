namespace DesignPatternsConsole.Models.Interpreter
{
    public class SeparatorExpression : IAbstractExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace(" ", "-");
        }
    }
}
