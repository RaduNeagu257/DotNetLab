using CompanyManagement.Database.Context;

namespace CompanyManagement.Database.Repositories
{
    public class BaseRepository
    {
        protected readonly CompanyDbContext _libraryDbContext;

        public BaseRepository(CompanyDbContext libraryDbContext)
        {
            this._libraryDbContext = libraryDbContext;
        }

        public void SaveChanges()
        {
            _libraryDbContext.SaveChanges();
        }
    }
}
