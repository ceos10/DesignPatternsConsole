using DesignPatternsConsole.Models.State;

namespace DesignPatternsConsole.Logic.Behavioral
{
    public class StatePattern
    {
        public void RunExample() 
        {
            Account account = new Account("Leonel Messi");

            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);
        }
    }
}
