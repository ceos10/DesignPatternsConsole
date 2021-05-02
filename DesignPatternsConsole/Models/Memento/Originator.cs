namespace DesignPatternsConsole.Models.Memento
{
    public class Originator
    {
        public LedTv LedTv { get; set; }

        public Memento CreateMemento()
        {
            return new Memento(LedTv);
        }
        public void SetMemento(Memento memento) => LedTv = memento.LedTv;
        public string GetDetails() => $"Originator [ledTV={LedTv.GetDetails()}]";
    }
}
