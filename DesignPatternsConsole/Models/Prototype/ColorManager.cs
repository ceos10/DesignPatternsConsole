using System.Collections.Generic;

namespace DesignPatternsConsole.Models.Prototype
{
    public class ColorManager
    {
        private readonly Dictionary<string, Color> _colors = new Dictionary<string, Color>();

        public Color this[string key]
        {
            get { return _colors[key]; }
            set { _colors.Add(key, value); }
        }
    }
}
