using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMgt_Tejbir.BussyLayer
{
    public class Job
    {
        public int ID { get; set; }
        public string JobName { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
