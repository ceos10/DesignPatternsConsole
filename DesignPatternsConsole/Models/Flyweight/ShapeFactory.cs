using System;
using System.Collections.Generic;

namespace DesignPatternsConsole.Models.Flyweight
{
    public static class ShapeFactory
    {
        private static readonly Dictionary<string, IShape> shapeMap = new Dictionary<string, IShape>();
        public static IShape GetShape(string shapeType)
        {
            IShape shape = null;
            if (shapeType.Equals("circle", StringComparison.InvariantCultureIgnoreCase))
            {
                if (shapeMap.TryGetValue("circle", out shape))
                {
                    return shape;
                }

                shape = new Circle();
                shapeMap.Add("circle", shape);
                Console.WriteLine(" Creating circle object with out any color in shapefactory \n");
                return shape;
            }
            return shape;
        }
    }
}
