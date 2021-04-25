using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsConsole.Models.Prototype
{
    public partial class Color
    {
        private readonly int _red;
        private readonly int _green;
        private readonly int _blue;

        public Color(int red, int green, int blue)
        {
            this._red = red;
            this._green = green;
            this._blue = blue;
        }

        public Color Clone()
        {
            Console.WriteLine(
              "Cloning color RGB: {0,3},{1,3},{2,3}",
              _red, _green, _blue);

            return (Color)this.MemberwiseClone();
        }
    }
}
