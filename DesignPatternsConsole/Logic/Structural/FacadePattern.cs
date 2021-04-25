using System;
using DesignPatternsConsole.Models.Facade;

namespace DesignPatternsConsole.Logic.Structural
{
    public class FacadePattern
    {
        public void RunExample()
        {
            Order order = new Order();
            order.PlaceOrder();
        }
    }
}
