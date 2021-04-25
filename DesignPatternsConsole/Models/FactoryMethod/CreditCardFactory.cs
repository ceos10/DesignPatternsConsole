namespace DesignPatternsConsole.Models.FactoryMethod
{
    public abstract class CreditCardFactory
    {
        protected abstract ICreditCard MakeProduct();
        public ICreditCard CreateProduct() => this.MakeProduct();
    }
}
