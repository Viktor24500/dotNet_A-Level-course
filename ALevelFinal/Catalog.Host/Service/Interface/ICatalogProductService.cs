using Catalog.Host.Data.Entities;

namespace Catalog.Host.Service.Interface
{
    public interface ICatalogProductService
    {
        public Task<Product> GetProductByID(int id);
        Task<Product> GetProductByCategory(Category category);
    }
}
