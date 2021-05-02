using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsConsole.Models.Observer
{
    public abstract class Stock
    {
        private readonly string _symbol;
        private double _price;
        private readonly List<IInvestor> _investors = new List<IInvestor>();

        protected Stock(string symbol, double price)
        {
            _symbol = symbol;
            _price = price;
        }

        public void Attach(IInvestor investor) => _investors.Add(investor);

        public void Detach(IInvestor investor) => _investors.Remove(investor);

        public void Notify()
        {
            foreach (var investor in _investors)
            {
                investor.Update(this);
            }

            Console.WriteLine("");
        }

        public double Price
        {
            get { return _price; }
            set

            {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }

        public string Symbol
        {
            get { return _symbol; }
        }
    }
}
