using Catalog.Host.Data.Entities;
using Catalog.Host.Service.Interface;

namespace Catalog.Host.Service
{
    public class CatalogProductService : ICatalogProductService
    {
        public Task<Product> GetProductByID(int id)
        {
            Product product = new Product();
            return product;
        }

        public Task<Product> GetProductByCategory(Category category)
        {
            Product product = new Product();
            return product;
        }
    }
}
