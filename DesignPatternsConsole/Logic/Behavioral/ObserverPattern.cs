using DesignPatternsConsole.Models.Observer;

namespace DesignPatternsConsole.Logic.Behavioral
{
    public class ObserverPattern : IPattern
    {
        public void RunExample()
        {
            Ibm ibm = new Ibm("IBM", 120.00);

            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("Berkshire"));

            // Fluctuating prices will notify investors
            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;
        }
    }
}
