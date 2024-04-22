using CompanyManagement.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace CompanyManagement.Database.Context
{
    public class CompanyDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public CompanyDbContext(DbContextOptions<CompanyDbContext> options) : base(options) { }
    }
}
