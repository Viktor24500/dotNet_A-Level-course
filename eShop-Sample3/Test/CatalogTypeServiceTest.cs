using AutoMapper;
using Catalog.Host.Data.Entities;
using Catalog.Host.Data;
using Catalog.Host.Models.Dtos;
using Catalog.Host.Models.Requests.AddRequests;
using Catalog.Host.Models.Requests.DeleteRequests;
using Catalog.Host.Models.Requests.UpdateRequests;
using Catalog.Host.Repositories.Interfaces;
using Catalog.Host.Services.Interfaces;
using Catalog.Host.Services;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ServiceTest
{
    [TestClass]
    public class CatalogTypeServiceTest
    {
        private readonly ICatalogTypeRepository _catalogTypeRepository;
        private readonly IMapper _mapper;
        private readonly IDbContextWrapper<ApplicationDbContext> dbContextWrapper;
        private readonly ILogger<BaseDataService<ApplicationDbContext>> logger;
        private readonly AddCatalogTypeRequest _testType = new AddCatalogTypeRequest
        {
            Type = "Type1"
        };

        [TestMethod]
        public async Task AddAsync_Success()
        {
            //Arrange
            Catalog.Host.Services.CatalogTypeService catalogTypeService = new Catalog.Host.Services.CatalogTypeService(dbContextWrapper, logger, _catalogTypeRepository, _mapper);

            //Act
            var result = await catalogTypeService.AddAsync(_testType);

            //Assert
            result.Equals(1);
        }

        [TestMethod]
        public async Task AddAsync_Fail()
        {
            //Arrange
            Catalog.Host.Services.CatalogTypeService catalogTypeService = new Catalog.Host.Services.CatalogTypeService(dbContextWrapper, logger, _catalogTypeRepository, _mapper);

            //Act
            var result = await catalogTypeService.AddAsync(_testType);

            //Assert
            result.Equals(null);
        }

        [TestMethod]
        public async Task GetByPageAsyncHttpGet_Success()
        {
            //Arrange
            int pageSize = 10;
            int pageIndex = 0;
            Catalog.Host.Services.CatalogTypeService catalogTypeService = new Catalog.Host.Services.CatalogTypeService(dbContextWrapper, logger, _catalogTypeRepository, _mapper);

            //Act
            var result = await catalogTypeService.GetByPageAsyncHttpGet(pageSize, pageIndex);

            //Assert
            result.TotalCount.Equals(1);
            result.Data.Equals(1);
        }

        [TestMethod]
        public async Task UpdateAsync_Success()
        {
            //Arrange
            Catalog.Host.Services.CatalogTypeService catalogTypeService =
                new Catalog.Host.Services.CatalogTypeService(dbContextWrapper, logger, _catalogTypeRepository, _mapper);
            var updateCatalogType = new UpdateCatalogTypeRequest
            {
                Id = 1,
                Type = "UpdatedType"
            };
            var updatedType = new CatalogType
            {
                Id = updateCatalogType.Id,
                Type = updateCatalogType.Type
            };

            var expectedDto = new CatalogTypeDto
            {
                Id = updatedType.Id,
                Type = updatedType.Type
            };
            //Act
            var result = await catalogTypeService.UpdateAsync(updateCatalogType);

            //Assert
            Assert.IsNotNull(result.Type);
            Assert.Equals(expectedDto.Id, result.Type.Id);
            Assert.Equals(expectedDto.Type, result.Type.Type);
        }

        [TestMethod]
        public async Task UpdateAsync_Fail()
        {
            //Arrange
            Catalog.Host.Services.CatalogTypeService catalogTypeService =
                new Catalog.Host.Services.CatalogTypeService(dbContextWrapper, logger, _catalogTypeRepository, _mapper);
            var updateCatalogType = new UpdateCatalogTypeRequest
            {
                Id = 1,
                Type = "UpdatedType"
            };

            //Act
            var result = await catalogTypeService.UpdateAsync(updateCatalogType);

            //Assert
            result.Type.Equals(null);

        }

        [TestMethod]
        public async Task DeleteAsync_Success()
        {
            //Arrange
            Catalog.Host.Services.CatalogTypeService catalogTypeService =
                new Catalog.Host.Services.CatalogTypeService(dbContextWrapper, logger, _catalogTypeRepository, _mapper);
            var deleteCatalogType = new DeleteCatalogTypeRequest { Id = 1 };
            //Act
            await catalogTypeService.DeleteAsync(deleteCatalogType);

            //Assert
        }

        [TestMethod]
        public async Task DeleteAsync_Fail()
        {
            //Arrange
            Catalog.Host.Services.CatalogTypeService catalogTypeService =
                new Catalog.Host.Services.CatalogTypeService(dbContextWrapper, logger, _catalogTypeRepository, _mapper);
            var deleteCatalogType = new DeleteCatalogTypeRequest { Id = 1 };

            //Act
            await catalogTypeService.DeleteAsync(deleteCatalogType);

            //Assert

        }
    }
}
