namespace DesignPatternsConsole.Models.FactoryMethod
{
    public class Platinum : ICreditCard
    {
        public string GetCardType() => "Platinum Plus";
        public int GetCreditLimit() => 35000;
        public int GetAnnualCharge() => 2000;
    }
}
