namespace DesignPatternsConsole.Models.FactoryMethod
{
    public class MoneyBackFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct() => new MoneyBack();
    }
}
