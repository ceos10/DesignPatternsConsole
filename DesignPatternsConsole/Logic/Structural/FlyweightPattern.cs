using System;
using DesignPatternsConsole.Models.Flyweight;

namespace DesignPatternsConsole.Logic.Structural
{
    public class FlyweightPattern : IPattern
    {
        public void RunExample()
        {
            Console.WriteLine("\n Red color Circles ");
            for (int i = 0; i < 3; i++)
            {
                Circle circle = (Circle)ShapeFactory.GetShape("circle");
                circle.SetColor("Red");
                circle.Draw();
            }
            Console.WriteLine("\n Black color Circles");
            for (int i = 0; i < 3; ++i)
            {
                Circle circle = (Circle)ShapeFactory.GetShape("circle");
                circle.SetColor("Black");
                circle.Draw();
            }
        }
    }
}
