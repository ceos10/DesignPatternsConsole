using System;

namespace DesignPatternsConsole.Models.State
{
    public class RedState : State
    {
        private double _serviceFee;
        public RedState(State state)
        {
            Balance = state.Balance;
            Account = state.Account;
            Initialize();
        }

        private void Initialize()
        {
            _interest = 0.0;
            _lowerLimit = -100.0;
            _upperLimit = 0.0;
            _serviceFee = 15.00;
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            Console.WriteLine("No funds available for withdrawal!");
        }

        public override void PayInterest()
        {
            // No interest is paid
        }

        private void StateChangeCheck()
        {
            if (Balance > _upperLimit)
            {
                Account.State = new SilverState(this);
            }
        }
    }
}
