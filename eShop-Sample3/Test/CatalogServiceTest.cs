using AutoMapper;
using Catalog.Host.Data;
using Catalog.Host.Repositories.Interfaces;
using Catalog.Host.Services;
using Catalog.Host.Services.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ServiceTest
{
    [TestClass]
    public class CatalogServiceTest
    {
        private readonly ICatalogItemRepository _catalogItemRepository;
        private readonly IMapper _mapper;
        private readonly IDbContextWrapper<ApplicationDbContext> dbContextWrapper;
        private readonly ILogger<BaseDataService<ApplicationDbContext>> logger;

        [TestMethod]
        public async void GetCatalogItemsAsync_Success()
        {
            //Arrange
            int pageSize = 10;
            int pageIndex = 0;
            CatalogService catalogService = new CatalogService(dbContextWrapper, logger, _catalogItemRepository, _mapper);

            //Act
            var result = await catalogService.GetCatalogItemsAsync(pageSize, pageIndex);

            //Assert
            result.PageIndex.Equals(pageIndex);
            result.PageSize.Equals(pageSize);
            result.Count.Equals(1);
        }
    }
}