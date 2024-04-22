using CompanyManagement.Database.Entities;

namespace CompanyManagement.Database.Repositories
{
    public interface IDepartmentRepository
    {
        List<Department> GetDepartments(); 

        int CreateDepartment(Department Department);
    }
}
