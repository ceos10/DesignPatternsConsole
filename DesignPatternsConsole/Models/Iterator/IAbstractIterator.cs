namespace DesignPatternsConsole.Models.Iterator
{
    public interface IAbstractIterator
    {
        Employee First();
        Employee Next();
        bool IsCompleted { get; }
    }
}
