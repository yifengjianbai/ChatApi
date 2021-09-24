using DbService.EfCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DbService.Repositories
{
    public interface IRpRepository<T> : IRepository<T, RpDbContext> where T : class
    {
    }
}
