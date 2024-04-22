using CompanyManagement.Database.Entities;

namespace CompanyManagement.Database.Repositories
{
    public interface IEmployeeRepository
    {
        int CreateEmployee(Employee Employee);
    }
}
