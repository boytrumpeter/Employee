namespace EmployeeApplication.Interfaces
{
    using EmployeeApplication.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public  interface IEmployeeService
    {
        Task<IEnumerable<EmployeeModel>> GetAllEmployeeAsync();
    }
}
