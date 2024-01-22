using Catalog.Host.Data.Entities;

namespace Catalog.Host.Service.Interface
{
    public interface ICatalogCategoryService
    {
        public List<Category> GetCategories();
    }
}
