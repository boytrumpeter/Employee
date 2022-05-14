namespace EmployerInfrastructure.Repositories
{
    using EmployerDomain.Entities;
    using EmployerDomain.Interfaces;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class EmployeeRepository :RepositoryBase<Employee>, IEmployeeRepository
    {
        private readonly EmployeeDbContext _employeeDbContext;

        public EmployeeRepository(EmployeeDbContext employerDbConext) : base(employerDbConext)
        {
            _employeeDbContext = employeeDbContext;
        }

        public Employee CreateEmployee(Employee employee)
        {
            return Create(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            Delete(employee);
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeeAsync()
        {
            return await FindAll()
                .ToListAsync();
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            return await FindAll()
                .OrderBy(x => x.EmployeeId)
                .ToListAsync();
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            return await FindByCondition(x => x.EmployeeId == id)
                .FirstOrDefaultAsync();
        }

        public async Task<Employee> GetEmployeeWithDetailsAsync(int id)
        {
            return await FindByCondition(x => x.EmployeeId == id)
                .FirstOrDefaultAsync();
        }

        public async Task SaveAsync()
        {
            await _employeeDbContext.SaveChangesAsync();
        }

        public void SaveEmployee()
        {
            SaveChanges();
        }

        public bool UpdateEmployee(Employee employee)
        {
            return Update(employee);
        }
    }
}
