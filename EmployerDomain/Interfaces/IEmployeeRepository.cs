namespace EmployerDomain.Interfaces
{
    using EmployerDomain.Entities;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IEmployeeRepository : IRepositoryBase<Employee>
    {
        Task<IEnumerable<Employee>> GetAllEmployeeAsync();
        Task<Employee> GetEmployeeByIdAsync(int id);
        Task<Employee> GetEmployeeWithDetailsAsync(int id);
        Employee CreateEmployee(Employee employee);
        bool UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
        void SaveEmployee();
        Task SaveAsync();
    }
}
