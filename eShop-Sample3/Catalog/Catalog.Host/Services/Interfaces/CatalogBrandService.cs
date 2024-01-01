using Catalog.Host.Data;
using Catalog.Host.Models.Dtos;
using Catalog.Host.Models.Requests.AddRequests;
using Catalog.Host.Models.Requests.DeleteRequests;
using Catalog.Host.Models.Requests.UpdateRequests;
using Catalog.Host.Models.Responses.UpdateResponses;
using Catalog.Host.Repositories.Interfaces;

namespace Catalog.Host.Services.Interfaces
{
    public class CatalogBrandService : BaseDataService<ApplicationDbContext>, ICatalogBrandService
    {
        private readonly ICatalogBrandRepository _catalogBrandRepository;

        public CatalogBrandService(
            IDbContextWrapper<ApplicationDbContext> dbContextWrapper,
            ILogger<BaseDataService<ApplicationDbContext>> logger,
            ICatalogBrandRepository catalogBrandRepository)
            : base(dbContextWrapper, logger)
        {
            _catalogBrandRepository = catalogBrandRepository;
        }

        public Task<int?> AddAsync(AddCatalogBrandRequest addCatalogBrand)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(DeleteCatalogBrandRequest deleteCatalogBrand)
        {
            throw new NotImplementedException();
        }

        public async Task<PaginatedItems<CatalogBrandDto>> GetByPageAsyncHttpGet(int pageIndex, int pageSize)
        {
            var result = await _catalogBrandRepository.GetByPageAsyncHttpGet(pageIndex, pageSize);

            var data = result.Data.Select(item => new CatalogBrandDto
            {
                Id = item.Id,
                Brand = item.Brand
            });

            return new PaginatedItems<CatalogBrandDto>
            {
                TotalCount = result.TotalCount,
                Data = data
            };
        }

        public Task<UpdateCatalogBrandResponse<int>> UpdateAsync(UpdateCatalogBrandRequest updateCatalogBrand)
        {
            throw new NotImplementedException();
        }
    }
}
