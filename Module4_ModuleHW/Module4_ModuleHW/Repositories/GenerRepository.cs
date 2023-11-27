using Microsoft.EntityFrameworkCore;
using Module4_ModuleHW.Configurations;

namespace Module4_ModuleHW.Repositories
{
    public class GenerRepository : BaseRepository
    {
        protected readonly AppDBContext _dbContext;

        public GenerRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public override async Task Create<T>(T model)
        {
            await _dbContext.Set<T>().AddAsync(model);
            _ = await _dbContext.SaveChangesAsync();
        }

        public override async Task Delete<T>(int id)
        {
            var entity = await _dbContext.Set<T>().FindAsync(id);

            if (entity != null)
            {
                _dbContext.Set<T>().Remove(entity);
                await _dbContext.SaveChangesAsync();
            }
        }

        public override async Task<IEnumerable<T>> GetAll<T>()
        {
            var entities = await _dbContext.Set<T>()
                .AsNoTracking()
                .ToListAsync();

            return entities;
        }

        public override async Task<T> GetOne<T>(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public override async Task Update<T>(T model)
        {
            _dbContext.Update(model);
            await _dbContext.SaveChangesAsync();
        }
    }
}
