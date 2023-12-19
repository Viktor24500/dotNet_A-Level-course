using Microsoft.AspNetCore.Mvc;

namespace Catalog.Host.Controllers
{
    [ApiController]
    [Route("[products]")]
    public class ProductsController : ControllerBase
    {
        private List<Product> _listProducts = new List<Product>()
        {
            new Product(1, "Product1", 100),
            new Product(2, "Product2", 150),
            new Product(3, "Product3", 200),
            new Product(4, "Product4", 250),
            new Product(5, "Product5", 500),
            new Product(6, "Product6", 1000)
        };

        [HttpGet]
        public List<Product> GetProduct(int id)
        {
            return _listProducts;
        }

        [HttpGet("{id}")]
        public List<Product> GetProductByID(int id)
        {
            return _listProducts[id];
        }
    }
}
