namespace DesignPatternsConsole.Models.State
{
    public class GoldState : State
    {
        public GoldState(State state)
          : this(state.Balance, state.Account)
        {
        }

        public GoldState(double balance, Account account)
        {
            Balance = balance;
            Account = account;
            Initialize();
        }

        private void Initialize()
        {
            _interest = 0.05;
            _lowerLimit = 1000.0;
            _upperLimit = 10000000.0;
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            Balance -= amount;
            StateChangeCheck();
        }

        public override void PayInterest()
        {
            Balance += _interest * Balance;
            StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            if (Balance < 0.0)
            {
                Account.State = new RedState(this);
            }
            else if (Balance < _lowerLimit)
            {
                Account.State = new SilverState(this);
            }
        }
    }
}
