namespace DesignPatternsConsole.Models.FactoryMethod
{
    public class TitaniumFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct() => new Titanium();
    }
}
