using Emp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emp.Core.ViewModels
{
    public class EmployeeViewModel
    {
        public string PageTitle { get; set; }
        
        public IEnumerable<Employee> Employees { get; set; }
    }
}
