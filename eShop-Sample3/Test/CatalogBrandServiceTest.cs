using AutoMapper;
using Catalog.Host.Data;
using Catalog.Host.Repositories.Interfaces;
using Catalog.Host.Services.Interfaces;
using Catalog.Host.Services;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Catalog.Host.Models.Requests.AddRequests;
using Catalog.Host.Models.Requests.DeleteRequests;
using Catalog.Host.Models.Requests.UpdateRequests;
using Catalog.Host.Data.Entities;
using Catalog.Host.Models.Dtos;

namespace Test
{
    [TestClass]
    public class CatalogBrandServiceTest
    {
        private readonly ICatalogBrandRepository _catalogBrandRepository;
        private readonly IMapper _mapper;
        private readonly IDbContextWrapper<ApplicationDbContext> dbContextWrapper;
        private readonly ILogger<BaseDataService<ApplicationDbContext>> logger;
        private readonly AddCatalogBrandRequest _testBrand = new AddCatalogBrandRequest
        {
            Brand = "Brand1"
        };

        [TestMethod]
        public async Task AddAsync_Success()
        {
            //Arrange
            Catalog.Host.Services.CatalogBrandService catalogBrandService = new Catalog.Host.Services.CatalogBrandService(dbContextWrapper, logger, _catalogBrandRepository, _mapper);

            //Act
            var result = await catalogBrandService.AddAsync(_testBrand);

            //Assert
            result.Equals(1);
        }

        [TestMethod]
        public async Task AddAsync_Fail()
        {
            //Arrange
            Catalog.Host.Services.CatalogBrandService catalogBrandService = new Catalog.Host.Services.CatalogBrandService(dbContextWrapper, logger, _catalogBrandRepository, _mapper);

            //Act
            var result = await catalogBrandService.AddAsync(_testBrand);

            //Assert
            result.Equals(null);
        }

        [TestMethod]
        public async Task GetByPageAsyncHttpGet_Success()
        {
            //Arrange
            int pageSize = 10;
            int pageIndex = 0;
            Catalog.Host.Services.CatalogBrandService catalogBrandService = new Catalog.Host.Services.CatalogBrandService(dbContextWrapper, logger, _catalogBrandRepository, _mapper);

            //Act
            var result = await catalogBrandService.GetByPageAsyncHttpGet(pageSize, pageIndex);

            //Assert
            result.TotalCount.Equals(1);
            result.Data.Equals(1);
        }

        [TestMethod]
        public async Task UpdateAsync_Success()
        {
            //Arrange
            Catalog.Host.Services.CatalogBrandService catalogBrandService =
                new Catalog.Host.Services.CatalogBrandService(dbContextWrapper, logger, _catalogBrandRepository, _mapper);
            var updateCatalogBrand = new UpdateCatalogBrandRequest
            {
                Id = 1,
                Brand = "UpdatedBrand"
            };
            var updatedBrand = new CatalogBrand
            {
                Id = updateCatalogBrand.Id,
                Brand = updateCatalogBrand.Brand
            };

            var expectedDto = new CatalogBrandDto
            {
                Id = updatedBrand.Id,
                Brand = updatedBrand.Brand
            };
            //Act
            var result = await catalogBrandService.UpdateAsync(updateCatalogBrand);

            //Assert
            Assert.IsNotNull(result.Brand);
            Assert.Equals(expectedDto.Id, result.Brand.Id);
            Assert.Equals(expectedDto.Brand, result.Brand.Brand);
        }

        [TestMethod]
        public async Task UpdateAsync_Fail()
        {
            //Arrange
            Catalog.Host.Services.CatalogBrandService catalogBrandService =
                new Catalog.Host.Services.CatalogBrandService(dbContextWrapper, logger, _catalogBrandRepository, _mapper);
            var updateCatalogBrand = new UpdateCatalogBrandRequest
            {
                Id = 1,
                Brand = "UpdatedBrand"
            };

            //Act
            var result = await catalogBrandService.UpdateAsync(updateCatalogBrand);

            //Assert
            result.Brand.Equals(null);

        }

        [TestMethod]
        public async Task DeleteAsync_Success()
        {
            //Arrange
            Catalog.Host.Services.CatalogBrandService catalogBrandService =
                new Catalog.Host.Services.CatalogBrandService(dbContextWrapper, logger, _catalogBrandRepository, _mapper);
            var deleteCatalogBrand = new DeleteCatalogBrandRequest { Id = 1 };
            //Act
            await catalogBrandService.DeleteAsync(deleteCatalogBrand);

            //Assert
        }

        [TestMethod]
        public async Task DeleteAsync_Fail()
        {
            //Arrange
            Catalog.Host.Services.CatalogBrandService catalogBrandService =
                new Catalog.Host.Services.CatalogBrandService(dbContextWrapper, logger, _catalogBrandRepository, _mapper);
            var deleteCatalogBrand = new DeleteCatalogBrandRequest { Id = 1 };

            //Act
            await catalogBrandService.DeleteAsync(deleteCatalogBrand);

            //Assert

        }
    }
}
