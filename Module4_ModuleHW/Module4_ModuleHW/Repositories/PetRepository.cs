using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Module4_ModuleHW.Configurations;
using Module4_ModuleHW.DTO;

namespace Module4_ModuleHW.Repositories
{
    public class PetRepository : GenerRepository, IPageFilter
    {
        public PetRepository(AppDBContext dbContext) : base(dbContext)
        {
        }


        public async Task<IEnumerable<T>> GetPagesByFilters<T>(int page, int pageSize, int? minAge, int? maxAge, string name, bool descendingOrder) where T : class
        {
            IQueryable<Pet> query = _dbContext.Set<Pet>();

            if (minAge.HasValue)
            {
                query = query.Where(p => p.petAge >= minAge.Value);
            }

            if (maxAge.HasValue)
            {
                query = query.Where(p => p.petAge <= maxAge.Value);
            }

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(p => p.petName.Contains(name));
            }

            query = descendingOrder ? query.OrderByDescending(p => p.petName) : query.OrderBy(p => p.petName);

            return (IEnumerable<T>)await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
