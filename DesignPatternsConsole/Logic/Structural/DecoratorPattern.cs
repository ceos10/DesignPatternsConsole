using DesignPatternsConsole.Models.Decorator;
using System;

namespace DesignPatternsConsole.Logic.Structural
{
    public class DecoratorPattern
    {
        public void RunExample() 
        {
            PlainPizza plainPizza = new PlainPizza();
            Console.WriteLine(plainPizza.MakePizza());
            
            PizzaDecorator chickenPizzaDecorator = new ChickenPizzaDecorator(plainPizza);
            Console.WriteLine($"{chickenPizzaDecorator.MakePizza()} using ChickenPizzaDecorator");
            
            VegPizzaDecorator vegPizzaDecorator = new VegPizzaDecorator(plainPizza);
            Console.WriteLine($"{vegPizzaDecorator.MakePizza()} using VegPizzaDecorator");
        }
    }
}

