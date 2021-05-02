using DesignPatternsConsole.Models.Builder;

namespace DesignPatternsConsole.Logic.Creational
{
    public class BuilderPattern : IPattern
    {
        public void RunExample()
        {
            Shop shop = new Shop();

            VehicleBuilder builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
        }
    }
}
