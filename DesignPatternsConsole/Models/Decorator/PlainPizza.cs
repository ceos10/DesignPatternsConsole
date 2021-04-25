using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsConsole.Models.Decorator
{
    public class PlainPizza : IPizza
    {
        public string MakePizza() => "Plain Pizza";
    }
}
