using System.Collections.Generic;
using System.Linq;

namespace TestMVCProject.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList = new List<Employee>();

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){ Id=1,Name="Ramdas", Email="ramjiwaghmare8@gmai.com",Department="Development"},               
                new Employee(){ Id=2,Name="Sweetha", Email="Sweetha@gmai.com",Department="HR"},
                new Employee(){ Id=3,Name="DK", Email="dk1992@gmai.com",Department="Marketing"},
                new Employee(){ Id=4,Name="Ismile", Email="ismilekhaja@gmai.com",Department="Testing"} ,                           
                new Employee(){ Id=5,Name="PC", Email="pc@gmai.com",Department="Account"}
            };
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e=>e.Id==Id);
        }
    }
}
