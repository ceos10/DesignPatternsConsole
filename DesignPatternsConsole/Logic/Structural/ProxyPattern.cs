using System;
using DesignPatternsConsole.Models.Proxy;

namespace DesignPatternsConsole.Logic.Structural
{
    public class ProxyPattern : IPattern
    {
        public void RunExample()
        {
            MathProxy proxy = new MathProxy();

            Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
            Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
            Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
            Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));
        }
    }
}
