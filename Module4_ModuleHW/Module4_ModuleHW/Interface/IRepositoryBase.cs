namespace Module4_ModuleHW.Interface
{
    public interface IRepositoryBase<T> where T : class
    {
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);

        IQueryable<T> GetAllAsync();

    }
}
