using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApplication.Models
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string AccountNumber { get; set; }
        public DateTime CreatedUTC { get; set; }
    }
}
