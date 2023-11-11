using Module4_ModuleHW.Entity;

namespace Module4_ModuleHW.Interface
{
    public interface IRepositoryProduct
    {
        Task CreateProductAsync(User product);
        Task UpdateProductAsync(User product);
        Task DeleteProductAsync(User productId);

        Task<User> GetProductAsync(User productId);
    }
}
