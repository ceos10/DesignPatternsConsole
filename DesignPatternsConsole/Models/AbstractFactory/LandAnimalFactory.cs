namespace DesignPatternsConsole.Models.AbstractFactory
{
    public class LandAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string AnimalType)
        {
            return AnimalType switch
            {
                "Dog" => new Dog(),
                "Cat" => new Cat(),
                "Lion" => new Lion(),
                _ => null,
            };
        }
    }
}