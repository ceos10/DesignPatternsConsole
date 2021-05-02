using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsConsole.Models.Memento
{
    public class LedTv
    {
        public string Size { get; set; }
        public string Price { get; set; }
        public bool USBSupport { get; set; }
        public LedTv(string size, string price, bool usbSupport)
        {
            Size = size;
            Price = price;
            USBSupport = usbSupport;
        }
        public string GetDetails() => $"LEDTV [Size={Size}, Price={Price}, USBSupport={USBSupport}]";
    }
}
