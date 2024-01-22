namespace Catalog.Host.Data.Entities
{
    public class ProductDTO
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }

        public float price { get; set; }

        public int amount { get; set; }

        public string pictureName { get; set; }

        public BrandDTO BrandDTO { get; set; }

        public CategoryDTO CategoryDTO { get; set; }

    }
}
