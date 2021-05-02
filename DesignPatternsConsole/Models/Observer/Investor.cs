using System;

namespace DesignPatternsConsole.Models.Observer
{
    public class Investor : IInvestor
    {
        private readonly string _name;

        public Investor(string name)
        {
            _name = name;
        }

        public void Update(Stock stock) => Console.WriteLine($"Notified {_name} of {stock.Symbol}'s change to {stock.Price}:C");

        public Stock Stock { get; set; }
    }
}
