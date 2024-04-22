using CompanyManagement.Core.Dtos.Request;
using CompanyManagement.Core.Dtos.Response;
using CompanyManagement.Core.Mapping;
using CompanyManagement.Database.Entities;
using CompanyManagement.Database.Repositories;

namespace CompanyManagement.Core.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _DepartmentRepository;

        public DepartmentService(IDepartmentRepository DepartmentRepository)
        {
            _DepartmentRepository = DepartmentRepository;
        }

        public List<DepartmentResponseDto> GetDepartments()
        {
            List<Department> Departments = _DepartmentRepository.GetDepartments();

            List<DepartmentResponseDto> DepartmentResponseDtos = new List<DepartmentResponseDto>();

            foreach (Department Department in Departments)
            {
                DepartmentResponseDtos.Add(Department.ToDepartmentResponseDto());
            }

            return DepartmentResponseDtos;
        }

        public int CreateDepartment(DepartmentRequestDto Department)
        {
            int id = _DepartmentRepository.CreateDepartment(Department.ToDepartment());
            return id;
        }
    }
}
