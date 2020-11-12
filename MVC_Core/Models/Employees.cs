using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Core.Models
{
    public class Employees
    {
        public long EmployeesId { get; set; }
        public string Name { get; set; }
    }
}
