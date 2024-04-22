using CompanyManagement.Core.Dtos.Request;
using CompanyManagement.Core.Dtos.Response;
using CompanyManagement.Database.Entities;

namespace CompanyManagement.Core.Mapping
{
    public static class DepartmentMappingExtensions
    {
        public static DepartmentResponseDto ToDepartmentResponseDto(this Department Department)
        {
            var result = new DepartmentResponseDto();

            result.Id = Department.Id;
            result.Name = Department.Name;

            List<EmployeeResponseDto> EmployeesDto = new List<EmployeeResponseDto>();

            foreach (var Employee in Department.Employees)
            {
                EmployeesDto.Add(Employee.ToEmployeeResponseDto());
            }

            result.Employees = EmployeesDto;

            return result;
        }

        public static Department ToDepartment(this DepartmentRequestDto Department)
        {
            return new Department
            {
                Name = Department.Name
            };
        }
    }
}
