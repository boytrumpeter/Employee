namespace EmployeeApplication.Services
{
    using AutoMapper;
    using EmployeeApplication.Interfaces;
    using EmployeeApplication.Models;
    using EmployerDomain.Interfaces;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<EmployeeModel>> GetAllEmployeeAsync()
        {
            var data = await _employeeRepository.GetAllEmployeeAsync();
            return _mapper.Map<IEnumerable<EmployeeModel>>(data);
        }
    }
}
