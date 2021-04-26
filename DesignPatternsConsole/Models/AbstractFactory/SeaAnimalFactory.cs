namespace DesignPatternsConsole.Models.AbstractFactory
{
    public class SeaAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string AnimalType)
        {
            return AnimalType switch
            {
                "Shark" => new Shark(),
                "Octopus" => new Octopus(),
                _ => null,
            };
        }
    }
}