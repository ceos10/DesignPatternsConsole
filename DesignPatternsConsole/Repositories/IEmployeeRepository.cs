using DesignPatternsConsole.Models;
using System.Collections.Generic;

namespace DesignPatternsConsole.Repositories
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();
    }
}
