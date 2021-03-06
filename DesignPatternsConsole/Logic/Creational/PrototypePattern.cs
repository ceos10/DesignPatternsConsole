using DesignPatternsConsole.Models.Prototype;

namespace DesignPatternsConsole.Logic.Creational
{
    public class PrototypePattern : IPattern
    {
        public void RunExample()
        {
            ColorManager colormanager = new ColorManager();

            // Initialize with standard colors
            colormanager["red"] = new Color(255, 0, 0);
            colormanager["green"] = new Color(0, 255, 0);
            colormanager["blue"] = new Color(0, 0, 255);

            // User adds personalized colors
            colormanager["angry"] = new Color(255, 54, 0);
            colormanager["peace"] = new Color(128, 211, 128);
            colormanager["flame"] = new Color(211, 34, 20);

            // User clones selected colors
            Color color1 = colormanager["red"].Clone();
            Color color2 = colormanager["peace"].Clone();
            Color color3 = colormanager["flame"].Clone();
        }
    }
}
