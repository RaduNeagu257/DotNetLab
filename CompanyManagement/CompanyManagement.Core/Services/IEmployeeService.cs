using CompanyManagement.Core.Dtos.Request;

namespace CompanyManagement.Core.Services
{
    public interface IEmployeeService
    {
        int CreateEmployee(EmployeeRequestDto Employee);
    }
}
