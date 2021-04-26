namespace DesignPatternsConsole.Models.AbstractFactory
{
    public class Cat : IAnimal
    {
        public string Speak()
        {
            return "Meow Meow Meow";
        }
    }
}
