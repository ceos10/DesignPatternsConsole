using DesignPatternsConsole.Models.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsConsole.Logic.Creational
{
    public class FactoryMethodPattern
    {
        public void RunExample()
        {
            ICreditCard creditCard = new PlatinumFactory().CreateProduct();
            Console.WriteLine($"Card Type : {creditCard.GetCardType()}");
            Console.WriteLine($"Credit Limit : {creditCard.GetCreditLimit()}");
            Console.WriteLine($"Annual Charge : {creditCard.GetAnnualCharge()}");
            
            Console.WriteLine("--------------");
            
            creditCard = new MoneyBackFactory().CreateProduct();
            Console.WriteLine($"Card Type : {creditCard.GetCardType()}");
            Console.WriteLine($"Credit Limit : {creditCard.GetCreditLimit()}");
            Console.WriteLine($"Annual Charge : {creditCard.GetAnnualCharge()}");

        }
    }
}
