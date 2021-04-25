namespace DesignPatternsConsole.Models.Decorator
{
    public class VegPizzaDecorator : PizzaDecorator
    {
        public VegPizzaDecorator(IPizza pizza) : base(pizza)
        {
        }
        public override string MakePizza() => pizza.MakePizza() + AddVegetables();
        private string AddVegetables() => ", Vegetables added";
    }
}
