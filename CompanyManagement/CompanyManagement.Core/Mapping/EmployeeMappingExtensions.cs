using CompanyManagement.Core.Dtos.Request;
using CompanyManagement.Core.Dtos.Response;
using CompanyManagement.Database.Entities;

namespace CompanyManagement.Core.Mapping
{
    public static class EmployeeMappingExtensions
    {
        public static EmployeeResponseDto ToEmployeeResponseDto(this Employee Employee)
        {
            var result = new EmployeeResponseDto
            {
                Id = Employee.Id,
                FullName = Employee.FullName,
            };

            return result;
        }

        public static Employee ToEmployee(this EmployeeRequestDto Employee)
        {
            return new Employee
            {
                FullName = Employee.FullName,
                DepartmentId = Employee.DepartmentId
            };
        }
    }
}
