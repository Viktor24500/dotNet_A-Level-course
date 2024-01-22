namespace Catalog.Host.Data.Entities
{
    public class Brand
    {
        public int brandID { get; set; }
        public string brandName { get; set; }

        public List<Product> Products = new List<Product>();
    }
}
