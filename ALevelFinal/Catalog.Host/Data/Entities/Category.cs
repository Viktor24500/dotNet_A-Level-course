namespace Catalog.Host.Data.Entities
{
    public class Category
    {
        public int categoryID { get; set; }
        public string categoryName { get; set; }

        public List<Product> Products = new List<Product>();
    }
}
