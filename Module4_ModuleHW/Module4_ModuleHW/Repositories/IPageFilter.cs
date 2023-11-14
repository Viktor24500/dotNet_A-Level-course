namespace Module4_ModuleHW.Repositories
{
    public interface IPageFilter
    {
        Task<IEnumerable<T>> GetPagesByFilters<T>(int page, int pageSize, int? minAge, int? maxAge, string name,
            bool descendingOrder) where T : class;
    }
}
