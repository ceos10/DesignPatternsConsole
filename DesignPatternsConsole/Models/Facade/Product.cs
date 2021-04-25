using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsConsole.Models.Facade
{
    public class Product
    {
        public void GetProductDetails() => Console.WriteLine("Fetching the Product Details");
    }
}
