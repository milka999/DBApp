using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBApp.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }    
        public string Surname { get; set; }
        public decimal Salary { get; set; }
        public DateTime Birthday { get; set; }
    }
}
