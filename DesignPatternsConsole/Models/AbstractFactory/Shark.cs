namespace DesignPatternsConsole.Models.AbstractFactory
{
    public class Shark : IAnimal
    {
        public string Speak()
        {
            return "Cannot Speak";
        }
    }
}
