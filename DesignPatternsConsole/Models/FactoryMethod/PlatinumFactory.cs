namespace DesignPatternsConsole.Models.FactoryMethod
{
    public class PlatinumFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct() => new Platinum();
    }
}
