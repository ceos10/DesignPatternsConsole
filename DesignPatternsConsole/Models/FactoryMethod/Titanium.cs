namespace DesignPatternsConsole.Models.FactoryMethod
{
    public class Titanium : ICreditCard
    {
        public string GetCardType() => "Titanium Edge";
        public int GetCreditLimit() => 25000;
        public int GetAnnualCharge() => 1500;
    }
}
