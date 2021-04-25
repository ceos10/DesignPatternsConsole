namespace DesignPatternsConsole.Models.Decorator
{
    public class ChickenPizzaDecorator : PizzaDecorator
    {
        public ChickenPizzaDecorator(IPizza pizza) : base(pizza)
        {
        }
        public override string MakePizza() => pizza.MakePizza() + AddChicken();
        private string AddChicken() => ", Chicken added";
    }
}
