using System;

namespace DesignPatternsConsole.Models.State
{
    public class Account
    {
        private readonly string _owner;
        public State State { get; set; }
        public double Balance => State.Balance;

        public Account(string owner)
        {
            _owner = owner;
            State = new SilverState(0.0, this);
        }

        public void Deposit(double amount)
        {
            State.Deposit(amount);
            Console.WriteLine("Deposited {0:C} --- ", amount);
            Console.WriteLine(" Balance = {0:C}", State.Balance);
            Console.WriteLine(" Status = {0}",
            State.GetType().Name);
            Console.WriteLine("");
        }

        public void Withdraw(double amount)
        {
            State.Withdraw(amount);
            Console.WriteLine("Withdrew {0:C} --- ", amount);
            Console.WriteLine(" Balance = {0:C}", State.Balance);
            Console.WriteLine(" Status = {0}\n",
            State.GetType().Name);
        }

        public void PayInterest()
        {
            State.PayInterest();
            Console.WriteLine("Interest Paid --- ");
            Console.WriteLine(" Balance = {0:C}", State.Balance);
            Console.WriteLine(" Status = {0}\n",
            State.GetType().Name);
        }
    }
}
