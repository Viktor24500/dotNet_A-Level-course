using Catalog.Host.Data.Entities;
using Catalog.Host.Service.Interface;

namespace Catalog.Host.Service
{
    public class CatalogCategoryService : ICatalogCategoryService
    {
        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            return categories;
        }
    }
}
