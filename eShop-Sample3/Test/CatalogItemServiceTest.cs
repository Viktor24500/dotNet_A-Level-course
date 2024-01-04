using AutoMapper;
using Catalog.Host.Data.Entities;
using Catalog.Host.Data;
using Catalog.Host.Models.Dtos;
using Catalog.Host.Models.Requests.DeleteRequests;
using Catalog.Host.Models.Requests.UpdateRequests;
using Catalog.Host.Repositories.Interfaces;
using Catalog.Host.Services.Interfaces;
using Catalog.Host.Services;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Catalog.Host.Models.Requests;

namespace ServiceTest
{
    [TestClass]
    public class CatalogItemServiceTest
    {
        private readonly ICatalogItemRepository _catalogItemRepository;
        private readonly IMapper _mapper;
        private readonly IDbContextWrapper<ApplicationDbContext> dbContextWrapper;
        private readonly ILogger<BaseDataService<ApplicationDbContext>> logger;
        private readonly AddCatalogItemRequest _testItem = new AddCatalogItemRequest
        {
            Name = "Name1",
            Description = "ServiceTest",
            Price = 1000,
            PictureFileName = "1.png",
            AvailableStock = 100
        };

        [TestMethod]
        public async Task AddAsync_Success()
        {
            //Arrange
            Catalog.Host.Services.CatalogItemService catalogItemService = new Catalog.Host.Services.CatalogItemService(dbContextWrapper, logger, _catalogItemRepository, _mapper);

            //Act
            var result = await catalogItemService.AddAsync(_testItem);

            //Assert
            result.Equals(1);
        }

        [TestMethod]
        public async Task AddAsync_Fail()
        {
            //Arrange
            Catalog.Host.Services.CatalogItemService catalogItemService = new Catalog.Host.Services.CatalogItemService(dbContextWrapper, logger, _catalogItemRepository, _mapper);

            //Act
            var result = await catalogItemService.AddAsync(_testItem);

            //Assert
            result.Equals(null);
        }

        [TestMethod]
        public async Task GetByPageAsyncHttpGet_Success()
        {
            //Arrange
            int pageSize = 10;
            int pageIndex = 0;
            Catalog.Host.Services.CatalogItemService catalogItemService = new Catalog.Host.Services.CatalogItemService(dbContextWrapper, logger, _catalogItemRepository, _mapper);

            //Act
            var result = await catalogItemService.GetByPageAsyncHttpGet(pageSize, pageIndex);

            //Assert
            result.TotalCount.Equals(1);
            result.Data.Equals(1);
        }

        [TestMethod]
        public async Task UpdateAsync_Success()
        {
            //Arrange
            Catalog.Host.Services.CatalogItemService catalogItemService =
                new Catalog.Host.Services.CatalogItemService(dbContextWrapper, logger, _catalogItemRepository, _mapper);
            var updateCatalogItem = new UpdateCatalogItemRequest
            {
                Id = 1,
                Name = "UpdatedName",
                Description = "UpdatedDescription",
                Price = 2000M,
                PictureFileName = "2.png",
                CatalogBrandId = 2,
                CatalogTypeId = 2,
                AvailableStock = 100
            };

            var updatedItem = new CatalogItem
            {
                Id = updateCatalogItem.Id,
                Name = updateCatalogItem.Name,
                Description = updateCatalogItem.Description,
                Price = updateCatalogItem.Price,
                PictureFileName = updateCatalogItem.PictureFileName,
                CatalogBrandId = updateCatalogItem.CatalogBrandId,
                CatalogTypeId = updateCatalogItem.CatalogTypeId,
                CatalogBrand = new CatalogBrand { Id = updateCatalogItem.CatalogBrandId, Brand = "TestBrand" },
                CatalogType = new CatalogType { Id = updateCatalogItem.CatalogTypeId, Type = "TestType" },
                AvailableStock = updateCatalogItem.AvailableStock
            };

            var expectedDto = new CatalogGetItemDto
            {
                Id = updatedItem.Id,
                Name = updatedItem.Name,
                Description = updatedItem.Description,
                Price = updatedItem.Price,
                PictureFileName = updatedItem.PictureFileName,
                BrandName = updatedItem.CatalogBrand.Brand,
                TypeName = updatedItem.CatalogType.Type,
                AvailableStock = updatedItem.AvailableStock
            };
            //Act
            var result = await catalogItemService.UpdateAsync(updateCatalogItem);

            //Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Item);
            Assert.AreEqual(expectedDto.Id, result.Item.Id);
            Assert.AreEqual(expectedDto.Name, result.Item.Name);
            Assert.AreEqual(expectedDto.Description, result.Item.Description);
            Assert.AreEqual(expectedDto.BrandName, result.Item.BrandName);
            Assert.AreEqual(expectedDto.TypeName, result.Item.TypeName);
        }

        [TestMethod]
        public async Task UpdateAsync_Fail()
        {
            //Arrange
            Catalog.Host.Services.CatalogItemService catalogItemService =
                new Catalog.Host.Services.CatalogItemService(dbContextWrapper, logger, _catalogItemRepository, _mapper);
            var updateCatalogItem = new UpdateCatalogItemRequest
            {
                Id = 1,
                Name = "UpdatedName",
                Description = "UpdatedDescription",
                Price = 2000M,
                PictureFileName = "2.png",
                CatalogBrandId = 2,
                CatalogTypeId = 2,
                AvailableStock = 100
            };

            var updatedItem = new CatalogItem
            {
                Id = updateCatalogItem.Id,
                Name = updateCatalogItem.Name,
                Description = updateCatalogItem.Description,
                Price = updateCatalogItem.Price,
                PictureFileName = updateCatalogItem.PictureFileName,
                CatalogBrandId = updateCatalogItem.CatalogBrandId,
                CatalogTypeId = updateCatalogItem.CatalogTypeId,
                CatalogBrand = new CatalogBrand { Id = updateCatalogItem.CatalogBrandId, Brand = "TestBrand" },
                CatalogType = new CatalogType { Id = updateCatalogItem.CatalogTypeId, Type = "TestType" },
                AvailableStock = updateCatalogItem.AvailableStock
            };

            var expectedDto = new CatalogGetItemDto
            {
                Id = updatedItem.Id,
                Name = updatedItem.Name,
                Description = updatedItem.Description,
                Price = updatedItem.Price,
                PictureFileName = updatedItem.PictureFileName,
                BrandName = updatedItem.CatalogBrand.Brand,
                TypeName = updatedItem.CatalogType.Type,
                AvailableStock = updatedItem.AvailableStock
            };

            //Act
            var result = await catalogItemService.UpdateAsync(updateCatalogItem);

            //Assert
            result.Item.Equals(null);
        }

        [TestMethod]
        public async Task DeleteAsync_Success()
        {
            //Arrange
            Catalog.Host.Services.CatalogItemService catalogItemService =
                new Catalog.Host.Services.CatalogItemService(dbContextWrapper, logger, _catalogItemRepository, _mapper);
            var deleteCatalogItem = new DeleteCatalogItemRequest { Id = 1 };
            //Act
            await catalogItemService.DeleteAsync(deleteCatalogItem);

            //Assert
        }

        [TestMethod]
        public async Task DeleteAsync_Fail()
        {
            //Arrange
            Catalog.Host.Services.CatalogItemService catalogItemService =
                new Catalog.Host.Services.CatalogItemService(dbContextWrapper, logger, _catalogItemRepository, _mapper);
            var deleteCatalogItem = new DeleteCatalogItemRequest { Id = 1 };

            //Act
            await catalogItemService.DeleteAsync(deleteCatalogItem);

            //Assert

        }
    }
}
