namespace DesignPatternsConsole.Models.AbstractFactory
{
    public class Dog : IAnimal
    {
        public string Speak()
        {
            return "Bark bark";
        }
    }
}
