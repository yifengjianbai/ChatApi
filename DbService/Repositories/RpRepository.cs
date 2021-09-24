using DbService.EfCore;
using DbService.Models;

namespace DbService.Repositories
{
    public class RpRepository<T> : Repository<T, RpDbContext>, IRpRepository<T> where T : class
    {
        public RpRepository(RpDbContext dbContext) : base(dbContext)
        { }
    }
}
