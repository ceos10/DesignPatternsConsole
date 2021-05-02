namespace DesignPatternsConsole.Models.Interpreter
{
    public interface IAbstractExpression
    {
        void Evaluate(Context context);
    }
}
