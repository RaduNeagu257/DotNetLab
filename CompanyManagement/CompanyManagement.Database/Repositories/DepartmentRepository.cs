using CompanyManagement.Database.Context;
using CompanyManagement.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace CompanyManagement.Database.Repositories
{
    public class DepartmentRepository : BaseRepository, IDepartmentRepository
    {
        public DepartmentRepository(CompanyDbContext libraryDbContext) : base(libraryDbContext)
        {
        }

        public List<Department> GetDepartments()
        {
            var result = _libraryDbContext.Departments
                .Include(a => a.Employees)
                .AsNoTracking()
                .ToList();

            return result;
        }

        public int CreateDepartment(Department Department)
        {
            _libraryDbContext.Departments.Add(Department);
            _libraryDbContext.SaveChanges();

            return Department.Id;
        }
    }
}
