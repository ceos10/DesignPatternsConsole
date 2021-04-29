namespace DesignPatternsConsole.Models.State
{
    public class SilverState : State
    {
        public SilverState(State state) :
          this(state.Balance, state.Account)
        {
        }

        public SilverState(double balance, Account account)
        {
            Balance = balance;
            Account = account;
            Initialize();
        }

        private void Initialize()
        {
            _interest = 0.0;
            _lowerLimit = 0.0;
            _upperLimit = 1000.0;
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
            if (Balance < _lowerLimit)
            {
                Account.State = new RedState(this);
            }
            else if (Balance > _upperLimit)
            {
                Account.State = new GoldState(this);
            }
        }
    }
}
