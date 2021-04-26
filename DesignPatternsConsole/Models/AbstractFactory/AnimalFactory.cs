namespace DesignPatternsConsole.Models.AbstractFactory
{
    public abstract class AnimalFactory
    {
        public abstract IAnimal GetAnimal(string AnimalType);
        public static AnimalFactory CreateAnimalFactory(string FactoryType) => FactoryType.Equals("Sea") ? new SeaAnimalFactory() : new LandAnimalFactory();
    }
}