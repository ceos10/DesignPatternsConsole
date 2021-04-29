using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsConsole.Models.State
{
    public abstract class State
    {
        public Account Account { get; set; }
        public double Balance { get; set; }

        protected double _interest;
        protected double _lowerLimit;
        protected double _upperLimit;

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public abstract void PayInterest();
    }
}
