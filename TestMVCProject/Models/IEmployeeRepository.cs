using System.Collections.Generic;

namespace TestMVCProject.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int Id);
        IEnumerable<Employee> GetAllEmployee();
    }
}
