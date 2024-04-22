using CompanyManagement.Core.Dtos.Response;
using CompanyManagement.Core.Dtos.Request;

namespace CompanyManagement.Core.Services
{
    public interface IDepartmentService
    {
        List<DepartmentResponseDto> GetDepartments();

        int CreateDepartment(DepartmentRequestDto Department);
    }
}
