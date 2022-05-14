using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApplication.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AccountNummber { get; set; }
        public DateTime CreatedUTC { get; set; }
    }
}
