using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsConsole.Models.Decorator
{
    public abstract class PizzaDecorator : IPizza
    {
        protected IPizza pizza;
        protected PizzaDecorator(IPizza pizza)
        {
            this.pizza = pizza;
        }

        public virtual string MakePizza() => pizza.MakePizza();
    }
}
