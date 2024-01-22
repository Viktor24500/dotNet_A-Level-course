namespace Catalog.Host.Data.Entities
{
    public class Product
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }

        public float price { get; set; }

        public int amount { get; set; }

        public string pictureName { get; set; }

        public int? brandID { get; set; }
        public Brand? Brand { get; set; }

        public int? categoryID { get; set; }
        public Category? Category { get; set; }

    }
}
