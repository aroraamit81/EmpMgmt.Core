using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emp.Core.Models;
using Emp.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Emp.Core.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {

            return View(new EmployeeViewModel()
            {
                Employees = _employeeService.GetEmployees(),
                PageTitle = "Employees"
            });
        }
        public IActionResult Details(int id)
        {
            var employee = _employeeService.GetEmployee(id);
            return View(new EmployeeDetailsViewModel()
            {
                Employee = employee,
                PageTitle = string.Format("Employee details for Employee Id={0}" + employee.EmpId)
            });
        }

    }
}