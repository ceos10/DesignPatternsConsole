using System.Collections.Generic;

namespace DesignPatternsConsole.Models.Iterator
{
    public class ConcreteCollection : IAbstractCollection
    {
        private readonly List<Employee> listEmployees = new List<Employee>();
        
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count
        {
            get { return listEmployees.Count; }
        }

        public void AddEmployee(Employee employee)
        {
            listEmployees.Add(employee);
        }

        public Employee GetEmployee(int IndexPosition)
        {
            return listEmployees[IndexPosition];
        }
    }
}
