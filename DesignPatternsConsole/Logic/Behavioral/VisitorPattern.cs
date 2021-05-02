using DesignPatternsConsole.Models.Visitor;

namespace DesignPatternsConsole.Logic.Behavioral
{
    public class VisitorPattern : IPattern
    {
        public void RunExample()
        {
            Employees e = new Employees();
            e.Attach(new Clerk());
            e.Attach(new Director());
            e.Attach(new President());

            e.Accept(new IncomeVisitor());
            e.Accept(new VacationVisitor());
        }
    }
}
