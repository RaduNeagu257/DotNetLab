using CompanyManagement.Core.Dtos.Request;
using CompanyManagement.Core.Mapping;
using CompanyManagement.Database.Repositories;

namespace CompanyManagement.Core.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _EmployeeRepository;

        public EmployeeService(IEmployeeRepository EmployeeRepository)
        {
            _EmployeeRepository = EmployeeRepository;
        }

        public int CreateEmployee(EmployeeRequestDto Employee)
        {
            int id = _EmployeeRepository.CreateEmployee(Employee.ToEmployee());
            return id;
        }
    }
}
