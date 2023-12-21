using Catalog.Host.Data;
using Catalog.Host.Models.Dtos;
using Catalog.Host.Models.Requests;

namespace Catalog.Host.Services.Interfaces
{
    public interface ICatalogTypeService
    {
        Task<PaginatedItems<CatalogTypeDto>> GetByPageAsyncHttpGet(int pageIndex, int pageSize);
    }
}
