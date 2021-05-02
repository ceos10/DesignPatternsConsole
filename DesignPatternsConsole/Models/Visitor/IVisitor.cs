using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsConsole.Models.Visitor
{
    public interface IVisitor
    {
        void Visit(Element element);
    }
}
