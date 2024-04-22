using CompanyManagement.Database.Context;
using CompanyManagement.Database.Entities;

namespace CompanyManagement.Database.Repositories
{
    public class EmployeeRepository : BaseRepository, IEmployeeRepository
    {
        public EmployeeRepository(CompanyDbContext context) : base(context)
        {
        }

        public int CreateEmployee(Employee Employee)
        {
            var Department = _libraryDbContext.Departments.Find(Employee.DepartmentId);

            if(Department == null)
            {
                // Create middleware to handle exceptions
                throw new Exception("Department not found");
            }

            _libraryDbContext.Employees.Add(Employee);
            _libraryDbContext.SaveChanges();

            return Employee.Id;
        }
    }
}
