﻿using Catalog.Host.Data;
using Catalog.Host.Models.Dtos;

namespace Catalog.Host.Services.Interfaces
{
    public interface ICatalogBrandService
    {
        //Task<int?> Add(AddCatalogItemRequest addCatalogItem);
        Task<PaginatedItems<CatalogBrandDto>> GetByPageAsyncHttpGet(int pageIndex, int pageSize);
    }
}
