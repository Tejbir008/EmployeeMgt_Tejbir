using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMgt_Tejbir.BussyLayer
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public int DepartmentID { get; set; }
        public int JobID { get; set; }
        public Department Department { get; set; }
        public Job Job { get; set; }
    }
}
