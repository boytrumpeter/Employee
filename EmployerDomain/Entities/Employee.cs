using System;
using System.Collections.Generic;
using System.Text;

namespace EmployerDomain.Entities
{
    public class Employee
    {
        public int EmployeeId{ get; set; }
        public string EmployeeName { get; set; }
        public string AccountNumber{ get; set; }
        public DateTime CreatedUTC{ get; set; }
    }
}
