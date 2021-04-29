using DesignPatternsConsole.Models.TemplateMethod;
using System;

namespace DesignPatternsConsole.Logic.Behavioral
{
    public class TemplateMethodPattern
    {
        public void RunExample()
        {
            Console.WriteLine("Nescafe Coffee Preparation\n");
            CoffeeTemplate coffee = new NescafeCoffee();
            coffee.PrepareCoffee();
            Console.WriteLine();
            Console.WriteLine("Bru coffee preparation\n");
            coffee = new BruCoffee();
            coffee.PrepareCoffee();
        }
    }
}
