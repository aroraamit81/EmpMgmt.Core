using System.Collections.Generic;
using System.Linq;

namespace Emp.Core.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
    }

    public interface IEmployeeService
    {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetEmployees();
        void Save(Employee employee);
    }

    public class MockEmployeeService : IEmployeeService
    {
        private IEnumerable<Employee> _employees;
        public MockEmployeeService()
        {
            _employees = new List<Employee>()
            {
                new Employee() { EmpId = 1, Name = "Mary", Department = "HR", Email = "mary@pragimtech.com" },
                new Employee() { EmpId = 2, Name = "John", Department = "IT", Email = "john@pragimtech.com" },
                new Employee() { EmpId = 3, Name = "Sam", Department = "IT", Email = "sam@pragimtech.com" }
            };
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return _employees;
        }
        public Employee GetEmployee(int id)
        {
            return _employees.FirstOrDefault(e => e.EmpId == id);
        }

        public void Save(Employee employee)
        {
            // Logic to save employee details
        }
    }
}
