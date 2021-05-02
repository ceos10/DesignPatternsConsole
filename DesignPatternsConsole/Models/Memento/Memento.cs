namespace DesignPatternsConsole.Models.Memento
{
    public class Memento
    {
        public LedTv LedTv { get; set; }
        public Memento(LedTv ledTV)
        {
            LedTv = ledTV;
        }
        public string GetDetails() => $"Memento [ledTV={LedTv.GetDetails()}]";
    }
}
