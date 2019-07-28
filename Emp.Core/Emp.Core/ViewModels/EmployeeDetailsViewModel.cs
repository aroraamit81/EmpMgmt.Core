using Emp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emp.Core.ViewModels
{
    public class EmployeeDetailsViewModel
    {
        public string PageTitle { get; set; }
        public Employee Employee { get; set; }
    }
}
