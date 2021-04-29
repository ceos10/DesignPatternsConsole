using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsConsole.Models.ChainOfResponsibility
{
    public abstract class Approver
    {
        protected Approver _successor;
        public void SetSuccessor(Approver successor) => _successor = successor;
        public abstract void ProcessRequest(Purchase purchase);
    }
}
